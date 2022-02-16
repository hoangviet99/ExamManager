using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Server.Enums;

namespace Server
{
    public class FileTransferSerialization
    {
        private byte[] DataSerialize(object obj)
        {
            using (var stream = new MemoryStream())
            {
                new BinaryFormatter().Serialize(stream, obj);
                return stream.ToArray();
            }
        }

        public object DataDeserialize(byte[] data)
        {
            using (var stream = new MemoryStream(data))
            {
                return new BinaryFormatter().Deserialize(stream);
            }
        }

        public bool SendMessage(string message, Socket socket)
        {
            TransferData transferData = new TransferData();
            transferData.DataType = DATA_TYPE.MESSAGE;
            transferData.Data = message;
            var objData = DataSerialize(transferData);

            try
            {
                socket.Send(objData);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SendFile(string filePath, Socket socket)
        {
            TransferData transferData = new TransferData();
            transferData.DataType = DATA_TYPE.FILE;

            string fileName = filePath.Substring(filePath.LastIndexOf(@"\") + 1);
            filePath = filePath.Substring(0, filePath.LastIndexOf(@"\") + 1);

            var data = new FileDataObject();
            data.FileName = fileName;
            data.FileData = File.ReadAllBytes(filePath + fileName);

            transferData.Data = data;
            var objData = DataSerialize(transferData);

            try
            {
                socket.Send(objData);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool SendFile_WithSubjectInfo(string filePath, Socket socket, SubjectInformation subjectInfo)
        {
            TransferData transferData = new TransferData();
            transferData.DataType = DATA_TYPE.FILE;

            string fileName = filePath.Substring(filePath.LastIndexOf(@"\") + 1);
            filePath = filePath.Substring(0, filePath.LastIndexOf(@"\") + 1);

            var data = new FileDataObject();
            data.FileName = fileName;
            data.FileData = File.ReadAllBytes(filePath + fileName);
            data.SubjectInfo = subjectInfo;

            transferData.Data = data;
            var objData = DataSerialize(transferData);

            try
            {
                socket.Send(objData);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool SendSubjectInfo(SubjectInformation subjectInfo, Socket socket)
        {
            TransferData transferData = new TransferData();
            transferData.DataType = DATA_TYPE.SUBJECT_INFORMATION;
            transferData.Data = subjectInfo;
            var objData = DataSerialize(transferData);

            try
            {
                socket.Send(objData);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool SendStudentInfo(StudentInformation studentInfo, Socket socket)
        {
            TransferData transferData = new TransferData();
            transferData.DataType = DATA_TYPE.STUDENT_INFORMATION;
            transferData.Data = studentInfo;
            var objData = DataSerialize(transferData);

            try
            {
                socket.Send(objData);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SendListStudentInfo(List<StudentInformation> listStudentInfo, Socket socket)
        {
            TransferData transferData = new TransferData();
            transferData.DataType = DATA_TYPE.LIST_STUDENT_INFORMATION;
            transferData.Data = listStudentInfo;
            var objData = DataSerialize(transferData);

            try
            {
                socket.Send(objData);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SendComputerInfo(ComputerInformation computerInfo, Socket socket)
        {
            TransferData transferData = new TransferData();
            transferData.DataType = DATA_TYPE.COMPUTER_INFORMATION;
            transferData.Data = computerInfo;
            var objData = DataSerialize(transferData);

            try
            {
                socket.Send(objData);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SendRequest(Socket socket, DATA_TYPE requestType)
        {
            TransferData transferData = new TransferData();
            transferData.DataType = requestType;
            transferData.Data = null;
            var objData = DataSerialize(transferData);

            try
            {
                socket.Send(objData);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SendListBlockingApplication(Socket socket, List<string> listApplication)
        {
            TransferData transferData = new TransferData();
            transferData.DataType = DATA_TYPE.BLOCKING_APPLICATION;
            transferData.Data = listApplication;
            var objData = DataSerialize(transferData);

            try
            {
                Thread.Sleep(200);
                socket.Send(objData);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SendScreenDisplay(Socket socket, Image screenDisplay)
        {
            TransferData transferData = new TransferData();
            transferData.DataType = DATA_TYPE.SCREEN_DISPLAY;
            transferData.Data = screenDisplay;
            var objData = DataSerialize(transferData);

            try
            {
                Thread.Sleep(500);
                socket.Send(objData);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
