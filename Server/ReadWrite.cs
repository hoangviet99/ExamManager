using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Server
{
    public static class ReadWrite
    {
        public static string ReadText_FromFile(string fileName)
        {
            FileStream fs;
            string result = "";

            if (File.Exists(fileName))
            {
                fs = new FileStream(fileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                result = sr.ReadLine();
                fs.Close();
            }
            else
            {
                fs = new FileStream(fileName, FileMode.Create);
                fs.Close();
            }
            return result;
        }

        public static void WriteText_ToFile(string fileName, string textData)
        {
            FileStream fs;
            fs = new FileStream(fileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.WriteLine(textData);
            sw.Flush();
            fs.Close();
        }

        public static List<string> ReadText_FromFile_ToListString(string fileName)
        {
            FileStream fs;
            var result = new List<string>();

            if (File.Exists(fileName))
            {
                fs = new FileStream(fileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    result.Add(str);
                }
                fs.Close();
            }
            else
            {
                fs = new FileStream(fileName, FileMode.Create);
                fs.Close();
            }
            return result;
        }

        public static void WriteText_FromListString_ToFile(string fileName, List<string> listString)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            foreach (var item in listString)
            {
                sw.WriteLine(item);
            }
            sw.Flush();
            fs.Close();
        }

        public static List<string> ReadExamList_FromFile()
        {
            string fileName = "ExamList.txt";
            FileStream fs;
            var result = new List<string>();

            if (File.Exists(fileName))
            {
                fs = new FileStream(fileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    result.Add(str);
                }
                fs.Close();
            }
            else
            {
                fs = new FileStream(fileName, FileMode.Create);
                fs.Close();
            }
            return result;
        }

        public static void WriteNewExam_ToFile(string examFilePath)
        {
            string fileName = "ExamList.txt";
            FileStream fs;
            if (File.Exists(fileName))
            {
                fs = new FileStream(fileName, FileMode.Append);
            }
            else
            {
                fs = new FileStream(fileName, FileMode.Create);
            }
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.WriteLine(examFilePath);
            sw.Flush();
            fs.Close();
        }

        public static void WriteListExam_ToFile(List<string> listExam)
        {
            string fileName = "ExamList.txt";
            FileStream fs = new FileStream(fileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            foreach (var item in listExam)
            {
                sw.WriteLine(item);
            }
            sw.Flush();
            fs.Close();
        }

        [DllImport("user32.dll")]
        static extern int GetWindowThreadProcessId(int hWnd, out int lpdwProcessId);

        static Process GetExcelProcess(Excel.Application excelApp)
        {
            int id;
            GetWindowThreadProcessId(excelApp.Hwnd, out id);
            return Process.GetProcessById(id);
        }

        public static List<StudentInformation> ReadListStudentInfo_FromExcelFile(string excelPath)
        {
            List<StudentInformation> listStudentInfo = new List<StudentInformation>();

            Excel.Application xlApp = new Excel.Application();

            var excelProcess = GetExcelProcess(xlApp);

            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(excelPath);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;

            for (int i = 2; i <= rowCount; i++)
            {
                var studentInfo = new StudentInformation();
                studentInfo.StudentID = xlRange.Cells[i, 1].Value2.ToString();
                studentInfo.StudentName = xlRange.Cells[i, 2].Value2.ToString();

                listStudentInfo.Add(studentInfo);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            xlWorkbook.Close(0);
            Marshal.ReleaseComObject(xlWorkbook);

            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

            excelProcess.Kill();

            return listStudentInfo;
        }
    }
}
