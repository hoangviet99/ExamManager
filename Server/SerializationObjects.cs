using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Enums;

namespace Server
{
    [Serializable]
    public class TransferData
    {
        public DATA_TYPE DataType { get; set; } 
        public Object Data { get; set; } 
    }

    [Serializable]
    public class FileDataObject
    {
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
        public SubjectInformation SubjectInfo { get; set; }
    }

    [Serializable]
    public class SubjectInformation
    {
        public string ClientPath { get; set; }
        public string SubjectName { get; set; }
        public int WorkingTime { get; set; }
        public string ExamTitle { get; set; }
    }

    [Serializable]
    public class StudentInformation
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string ClassName { get; set; }
    }

    [Serializable]
    public class ClassInformation
    {
        public string ClassName { get; set; }
    }

    [Serializable]
    public class ComputerInformation
    {
        public string ComputerName { get; set; }
        public string Username { get; set; }
        public string IPAddress { get; set; }
        public CONNECTION_STATE ConnectState { get; set; }
    }
}
