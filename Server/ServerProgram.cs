using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Server.Enums;

namespace Server
{
    class ServerProgram
    {
        public int Port { get; set; }
        public int MESSAGE_BUFFER_SIZE { get; set; }
        public int FILE_BUFFER_SIZE { get; set; }
        public string ServerPath { get; set; }
        public SubjectInformation SubjectInfo { get; set; }
        public List<StudentInformation> ListStudentInfo { get; set; }
        public List<uc_Computer> ListComputer { get; set; }
        public Action<ComputerInformation, StudentInformation> UpdateComputerInfo { get; set; }
        public Action<StudentInformation, string> SetStudentInfo { get; set; }
        public Action<string> SetNotify_RefuseConnecting { get; set; }
        public Action<int> SetLabelNumReadyStudent { get; set; }
        public Action<Image> SetStudentScreenDisplay { get; set; }

        private const int _1MB = 1024 * 1024;
        private FileTransferSerialization _fileTransfer;
        private Socket _serverSocket;
        private IPEndPoint _ipEndPoint;
        private List<Socket> _listClientSocket;

        private Thread _threadListen;
        private List<Thread> _listThreadReceive;

        public ServerProgram(int port)
        {
            Port = port;
            MESSAGE_BUFFER_SIZE = _1MB;
            FILE_BUFFER_SIZE = 500;
            SubjectInfo = new SubjectInformation();
            ListComputer = new List<uc_Computer>();

            _listClientSocket = new List<Socket>();
            _listThreadReceive = new List<Thread>();


            _fileTransfer = new FileTransferSerialization();

            _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _ipEndPoint = new IPEndPoint(IPAddress.Any, Port);
        }

        // ===================================================== PRIVATE METHOD ===================================================

        private void WriteReceivedSubmitExam(FileDataObject submitExam)
        {
            var savePath = ServerPath + submitExam.FileName;

            File.WriteAllBytes(savePath, submitExam.FileData);
        }

        private bool CheckIfClientCanConnect(Socket socket)
        {
            string clientIP = socket.RemoteEndPoint.ToString().Split(':')[0];
            var computer = ListComputer.Find(x => x.ComputerInfo.IPAddress.Equals(clientIP));

            if(computer == null || computer.ComputerInfo.ConnectState == CONNECTION_STATE.DISABLE)
            {
                _fileTransfer.SendMessage("/--[DenyToConnect]--/", socket);
                return false;
            }

            return true;
        }

        // ===================================================== PUBLIC METHOD ====================================================

        public void StartListen()
        {
            _serverSocket.Bind(_ipEndPoint);
            _threadListen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        _serverSocket.Listen(-1);
                        Socket clientSocket = _serverSocket.Accept();

                        if (!CheckIfClientCanConnect(clientSocket)) break;

                        _listClientSocket.Add(clientSocket);

                        Thread threadReceive = new Thread(() =>
                        {
                            byte[] data = new byte[_1MB * FILE_BUFFER_SIZE];
                            TransferData transferData;

                            try
                            {
                                int receiveLength = clientSocket.Receive(data);
                                transferData = (TransferData)_fileTransfer.DataDeserialize(data);

                                if(transferData.DataType == DATA_TYPE.COMPUTER_INFORMATION)
                                {
                                    var computerInfo = (ComputerInformation)transferData.Data;
                                    UpdateComputerInfo(computerInfo, null);
                                }

                                _fileTransfer.SendListStudentInfo(ListStudentInfo, clientSocket);
                                _fileTransfer.SendSubjectInfo(SubjectInfo, clientSocket);

                                SendBlockingApplication(clientSocket);

                                while (true)
                                {
                                    data = new byte[_1MB * FILE_BUFFER_SIZE];
                                    receiveLength = clientSocket.Receive(data);

                                    if (receiveLength == 0)
                                    {
                                        Remove_Client(clientSocket);
                                        clientSocket.Close();
                                        break;
                                    }

                                    transferData = (TransferData)_fileTransfer.DataDeserialize(data);
                                    switch (transferData.DataType)
                                    {
                                        case DATA_TYPE.STUDENT_INFORMATION:
                                            var studentInfo = (StudentInformation)transferData.Data;
                                            SetStudentInfo(studentInfo, clientSocket.RemoteEndPoint.ToString().Split(':')[0]);
                                            CountReadyStudent();
                                            break;

                                        case DATA_TYPE.FILE:
                                            var submitExam = (FileDataObject)transferData.Data;
                                            WriteReceivedSubmitExam(submitExam);
                                            break;

                                        case DATA_TYPE.SCREEN_DISPLAY:
                                            var screenDisplay = (Image)transferData.Data;
                                            SetStudentScreenDisplay(screenDisplay);
                                            break;

                                        default:
                                            break;
                                    }
                                }
                            }
                            catch (Exception)
                            {
                                Remove_Client(clientSocket);
                            }
                        });

                        _listThreadReceive.Add(threadReceive);
                        threadReceive.IsBackground = true;
                        threadReceive.Start();
                    }
                }
                catch (Exception) { }
            });

            _threadListen.IsBackground = true;
            _threadListen.Start();
        }

        private void Remove_Client(Socket clientSocket)
        {
            string clientIP = clientSocket.RemoteEndPoint.ToString().Split(':')[0];
            var computer = ListComputer.Find(x => x.ComputerInfo.IPAddress.Equals(clientIP));

            computer.ComputerInfo.ConnectState = CONNECTION_STATE.GONE;
            computer.UpdateInfo();

            _listClientSocket.Remove(clientSocket);
            clientSocket.Close();

            CountReadyStudent();
        }

        public void StartExam_SingleExam(string filePath, SubjectInformation subjectInfo)
        {
            Thread threadSendExam = new Thread(() =>
            {
                ListComputer.ForEach(computer =>
                {
                    if (computer.ComputerInfo.ConnectState == CONNECTION_STATE.READY)
                    {
                        computer.ComputerInfo.ConnectState = CONNECTION_STATE.DOING;
                        computer.UpdateInfo();

                        // Distribute exam title
                        var clientSocket = _listClientSocket.Find(x => x.RemoteEndPoint.ToString().Split(':')[0] == computer.ComputerInfo.IPAddress);

                        subjectInfo.ExamTitle = filePath.Substring(filePath.LastIndexOf(@"\") + 1);
                        _fileTransfer.SendFile_WithSubjectInfo(filePath, clientSocket, subjectInfo);
                    }
                });
            });
            threadSendExam.IsBackground = true;
            threadSendExam.Start();
        }

        public void StartExam_MultiExam(List<string> filePaths, SubjectInformation subjectInfo)
        {
            Thread threadSendExam = new Thread(() =>
            {
                int i = 0;

                ListComputer.ForEach(computer =>
                {
                    if(computer.ComputerInfo.ConnectState == CONNECTION_STATE.READY)
                    {
                        computer.ComputerInfo.ConnectState = CONNECTION_STATE.DOING;
                        computer.UpdateInfo();

                        // Distribute exam title
                        var clientSocket = _listClientSocket.Find(x => x.RemoteEndPoint.ToString().Split(':')[0] == computer.ComputerInfo.IPAddress);

                        if (i == filePaths.Count)
                        {
                            i = 0;
                        }

                        subjectInfo.ExamTitle = filePaths[i].Substring(filePaths[i].LastIndexOf(@"\") + 1);
                        _fileTransfer.SendFile_WithSubjectInfo(filePaths[i], clientSocket, subjectInfo);

                        i++;
                    }
                });
            });
            threadSendExam.IsBackground = true;
            threadSendExam.Start();
        }

        public void CountReadyStudent()
        {
            if (ListStudentInfo == null) return;

            int result = 0;

            ListStudentInfo.ForEach(studentInfo =>
            {
                var computerInfo = ListComputer.Find(x => (x.StudentInfo.StudentID == studentInfo.StudentID) && (x.ComputerInfo.ConnectState == CONNECTION_STATE.READY));
                if(computerInfo != null) result++;
            });

            SetLabelNumReadyStudent(result);
        }

        public void SendSubjectInfo()
        {
            foreach(var clientSocket in _listClientSocket)
            {
                _fileTransfer.SendSubjectInfo(SubjectInfo, clientSocket);
            }
        }

        public void SendStudentInfo()
        {
            if (ListStudentInfo == null) return;

            foreach (var clientSocket in _listClientSocket)
            {
                _fileTransfer.SendListStudentInfo(ListStudentInfo, clientSocket);
            }
        }

        public void SendMessageToAll(string message)
        {
            foreach (var clientSocket in _listClientSocket)
            {
                _fileTransfer.SendMessage(message, clientSocket);
            }
        }

        public void SendBlockingApplication(Socket socket)
        {
            List<string> listApplication = ReadWrite.ReadText_FromFile_ToListString("ListApplicationPrevent.txt");
            _fileTransfer.SendListBlockingApplication(socket, listApplication);
        }

        public void SendListBlockingApplicationToAll(List<string> listApplication)
        {
            foreach (var clientSocket in _listClientSocket)
            {
                _fileTransfer.SendListBlockingApplication(clientSocket, listApplication);
            }
        }

        public void SendDisconnectRequestToAll()
        {
            foreach (var clientSocket in _listClientSocket)
            {
                _fileTransfer.SendRequest(clientSocket, DATA_TYPE.REQUEST_DISCONNECT);
            }
        }

        public void SendActiveRequestToAll()
        {
            foreach (var clientSocket in _listClientSocket)
            {
                _fileTransfer.SendRequest(clientSocket, DATA_TYPE.REQUEST_ACTIVE);
            }
        }

        public void SendShutDownRequestToAll()
        {
            foreach (var clientSocket in _listClientSocket)
            {
                if (clientSocket.RemoteEndPoint.ToString().Split(':')[0].Equals("127.0.0.1")) continue;
                _fileTransfer.SendRequest(clientSocket, DATA_TYPE.REQUEST_SHUTDOWN);
            }
        }

        public void SendRestartRequestToAll()
        {
            foreach (var clientSocket in _listClientSocket)
            {
                if (clientSocket.LocalEndPoint.ToString().Split(':')[0].Equals("127.0.0.1")) continue;
                _fileTransfer.SendRequest(clientSocket, DATA_TYPE.REQUEST_RESTART);
            }
        }

        public void RequestViewStudentScreen(string ip)
        {
            Socket clientSocket = _listClientSocket.Find(x => x.RemoteEndPoint.ToString().Split(':')[0] == ip);

            _fileTransfer.SendRequest(clientSocket, DATA_TYPE.REQUEST_VIEW_SCREEN);
        }
        
        public void RequestStopViewStudentScreen(string ip)
        {
            Socket clientSocket = _listClientSocket.Find(x => x.RemoteEndPoint.ToString().Split(':')[0] == ip);

            _fileTransfer.SendRequest(clientSocket, DATA_TYPE.REQUEST_STOP_VIEW_SCREEN);
        }
    }
}
