using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class CMD
    {
        public static void OpenFile(string filePath)
        {
            Process.Start(filePath);
        }

        public static bool ExecuteCommand(string command)
        {
            try
            {
                string error = "", successful = "";

                ProcessStartInfo processStartInfo = new ProcessStartInfo();
                processStartInfo.ErrorDialog = false;
                processStartInfo.UseShellExecute = false;
                processStartInfo.RedirectStandardError = true;
                processStartInfo.RedirectStandardOutput = true;
                processStartInfo.CreateNoWindow = true;
                processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                processStartInfo.WorkingDirectory = @"C:\Windows\System32";
                processStartInfo.FileName = @"C:\Windows\System32\cmd.exe";
                processStartInfo.Verb = "runas";

                processStartInfo.Arguments = command;

                //Execute the process
                Process process = new Process();
                process.StartInfo = processStartInfo;
                bool processStarted = process.Start();
                if (processStarted)
                {
                    process.WaitForExit();

                    successful = process.StandardOutput.ReadToEnd();
                    error = process.StandardError.ReadToEnd();

                    process.StandardOutput.Close();
                    process.StandardError.Close();

                    if (successful != "")
                    {
                        return true;
                    }
                    else if (error != "")
                    {
                        return false;
                    }

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string CompressFile(string clientExamTitlePath, string outputFileName)
        {
            string examTitle = clientExamTitlePath.Substring(clientExamTitlePath.LastIndexOf(@"\") + 1);
            string clientPath = clientExamTitlePath.Substring(0, clientExamTitlePath.LastIndexOf(@"\") + 1);
            string outputFilePath = clientPath + outputFileName + ".rar";

            string winrarPath;
            if(Directory.Exists(@"C:\Program Files\WinRAR"))
            {
                winrarPath = @"C:\Program Files\WinRAR";
            }
            else
            {
                winrarPath = @"C:\Program Files (x86)\WinRAR";
            }

            try
            {
                string error = "", successful = "";

                ProcessStartInfo processStartInfo = new ProcessStartInfo();
                processStartInfo.ErrorDialog = false;
                processStartInfo.UseShellExecute = false;
                processStartInfo.RedirectStandardError = true;
                processStartInfo.RedirectStandardInput = true;
                processStartInfo.RedirectStandardOutput = true;
                processStartInfo.CreateNoWindow = true;
                processStartInfo.WindowStyle = ProcessWindowStyle.Maximized;

                processStartInfo.WorkingDirectory = @"C:\Windows\System32";
                processStartInfo.FileName = @"C:\Windows\System32\cmd.exe";
                processStartInfo.Verb = "runas";

                Process process = new Process();
                process.StartInfo = processStartInfo;
                bool processStarted = process.Start();
                if (processStarted)
                {
                    process.StandardInput.WriteLine(@"cd {0}", winrarPath);
                    process.StandardInput.Flush();
                    // rar a -ehs -x*\Debug -x*.vs -x*De1.docx -r V:\a.rar V:\*
                    process.StandardInput.WriteLine(@"rar a -ehs -x*\Debug -x*.vs -x*{0} -r {1} {2}*", examTitle, outputFilePath, clientPath);
                    process.StandardInput.Flush();
                    process.StandardInput.Close();

                    process.WaitForExit();

                    successful = process.StandardOutput.ReadToEnd();
                    error = process.StandardError.ReadToEnd();

                    process.StandardOutput.Close();
                    process.StandardError.Close();

                    if (successful != "")
                    {
                        return outputFilePath;
                    }
                    else if (error != "")
                    {
                        return null;
                    }

                    return null;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
