using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using Server;
using System.IO;
using Server.Enums;
using System.Diagnostics;
using System.Drawing;

namespace Client
{
    class ClientProgram
    {
        public IPAddress ServerIP { get; set; }
        public int ServerPort { get; set; }
        public int MESSAGE_BUFF_SIZE { get; set; }
        public Action<string> SetMessage { get; set; }
        public Action<string> ShowPopupWarning { get; set; }
        public Action<SubjectInformation, bool> SetSubjectInfo { get; set; }
        public Action<List<StudentInformation>> SetListStudentInfo { get; set; }
        public Action ExitProgram { get; set; }
        public Action ActiveAllControl { get; set; }

        private List<string> _listBlockingApplication;
        private IPEndPoint _ipEndPoint;
        private Socket _serverSocket;

        private FileTransferSerialization _fileTransfer;

        private Thread _threadReceive;
        private Thread _threadBlockingApp;
        private Thread _threadSendScreenDisplay;

        public ClientProgram(IPAddress serverIP, int serverPort)
        {
            ServerIP = serverIP;
            ServerPort = serverPort;

            MESSAGE_BUFF_SIZE = 1024;

            _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _fileTransfer = new FileTransferSerialization();
            _listBlockingApplication = new List<string>();
        }

        // ===================================================== PRIVATE METHOD ===================================================
        private void WriteReceivedExamTitle(FileDataObject fileData)
        {
            SubjectInformation subjectInfo = fileData.SubjectInfo;

            if (!Directory.Exists(subjectInfo.ClientPath))
            {
                Directory.CreateDirectory(subjectInfo.ClientPath);
            }

            var savePath = subjectInfo.ClientPath + fileData.FileName;

            File.WriteAllBytes(savePath, fileData.FileData);
        }

        private void StartTaskBlockingApplication()
        {
            _threadBlockingApp = new Thread(() =>
            {
                while (true)
                {
                    _listBlockingApplication.ForEach(appName =>
                    {
                        Process[] listProcess = Process.GetProcessesByName(appName);

                        if (listProcess.Length > 0)
                        {
                            foreach (var process in listProcess)
                            {
                                try
                                {
                                    process.Kill();
                                }
                                catch (Exception e) { Console.WriteLine(e); }
                            }
                        }
                    });

                    Thread.Sleep(500);
                }
            });

            _threadBlockingApp.IsBackground = true;
            _threadBlockingApp.Start();
        }

        private void SendScreenDisplay()
        {
            _threadSendScreenDisplay = new Thread(() =>
            {
                while (true)
                {
                    ScreenCapture sc = new ScreenCapture();
                    Image screenDisplay = sc.CaptureScreen();

                    _fileTransfer.SendScreenDisplay(_serverSocket, screenDisplay);
                }
            });

            _threadSendScreenDisplay.IsBackground = true;
            _threadSendScreenDisplay.Start();
        }

        private void StopSendScreenDisplay()
        {
            if (_threadSendScreenDisplay.IsAlive)
            {
                _threadSendScreenDisplay.Abort();
            }
        }

        // ===================================================== PUBLIC METHOD ====================================================

        public void Close()
        {
            _serverSocket.Shutdown(SocketShutdown.Both);
            _serverSocket.Close();
        }

        public bool Connect()
        {
            _ipEndPoint = new IPEndPoint(ServerIP, ServerPort);
            try
            {
                _serverSocket.Connect(_ipEndPoint);
            }
            catch (Exception)
            {
                return false;
            }

            _threadReceive = new Thread(() =>
            {
                try
                {
                    var computerInfo = new ComputerInformation();
                    computerInfo.IPAddress = _serverSocket.LocalEndPoint.ToString().Split(':')[0];
                    computerInfo.ConnectState = CONNECTION_STATE.CONNECTED;
                    computerInfo.ComputerName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\')[0];
                    computerInfo.Username = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\')[1];

                    _fileTransfer.SendComputerInfo(computerInfo, _serverSocket);

                    while (true)
                    {
                        byte[] data = new byte[1024 * 1024 * 500];

                        int receiveLength = _serverSocket.Receive(data);
                        var transferData = (TransferData)_fileTransfer.DataDeserialize(data);

                        switch (transferData.DataType)
                        {
                            case DATA_TYPE.FILE:
                                var fileData = (FileDataObject)transferData.Data;
                                WriteReceivedExamTitle(fileData);

                                SetSubjectInfo(fileData.SubjectInfo, true);
                                break;

                            case DATA_TYPE.SUBJECT_INFORMATION:
                                var subjectInfo = (SubjectInformation)transferData.Data;
                                SetSubjectInfo(subjectInfo, false);
                                break;

                            case DATA_TYPE.LIST_STUDENT_INFORMATION:
                                var listStudentInfo = (List<StudentInformation>)transferData.Data;
                                SetListStudentInfo(listStudentInfo);
                                break;

                            case DATA_TYPE.BLOCKING_APPLICATION:
                                _listBlockingApplication = (List<string>)transferData.Data;
                                StartTaskBlockingApplication();
                                break;

                            case DATA_TYPE.MESSAGE:
                                string message = (string)transferData.Data;
                                SetMessage(message);
                                break;

                            case DATA_TYPE.REQUEST_DISCONNECT:
                                Close();
                                ExitProgram();
                                break;

                            case DATA_TYPE.REQUEST_ACTIVE:
                                ActiveAllControl();
                                break;

                            case DATA_TYPE.REQUEST_SHUTDOWN:
                                CMD.ExecuteCommand("/c shutdown /s /t 0");
                                break;

                            case DATA_TYPE.REQUEST_RESTART:
                                CMD.ExecuteCommand("/c shutdown /r /t 0");
                                break;

                            case DATA_TYPE.REQUEST_VIEW_SCREEN:
                                SendScreenDisplay();
                                break;

                            case DATA_TYPE.REQUEST_STOP_VIEW_SCREEN:
                                StopSendScreenDisplay();
                                break;

                            default: 
                                break;
                        }
                    }
                }
                catch (Exception)  { }
            });

            _threadReceive.IsBackground = true;
            _threadReceive.Start();
            return true;
        }

        public void SendStudentInfo(StudentInformation studentInfo)
        {
            _fileTransfer.SendStudentInfo(studentInfo, _serverSocket);
        }

        public void SubmitExam(string examTitlePath, string submitFileName)
        {
            Thread threadSubmitExam = new Thread(() =>
            {
                string submitFiletPath = CMD.CompressFile(examTitlePath, submitFileName);
                if (submitFiletPath != null)
                {
                    _fileTransfer.SendFile(submitFiletPath, _serverSocket);
                    CMD.ExecuteCommand("/c del \"" + submitFiletPath + "\"");
                    CMD.ExecuteCommand("/c del \"" + examTitlePath + "\"");
                }
            });

            threadSubmitExam.Start();
        }
    }
}
