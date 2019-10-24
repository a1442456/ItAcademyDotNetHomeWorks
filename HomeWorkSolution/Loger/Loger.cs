using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace Loger
{
    public class Loger
    {
        const long MaxFileSize = 30000;
        const char indexDevider = '-';
        string _filePath;
        string _fileMask;

        public Loger()
        {   
                DateTime date = DateTime.Now;
                _fileMask = $"{date.Year}{date.Month}{date.Day}";
                _filePath = ConfigurationManager.AppSettings["LogPath"];

                if (!Directory.Exists(_filePath))
                    CreateDirectoriesToFile();

                if (IsNeedCreateNewFile())
                    CreateLogFile();
        }

        public void TypeInLogFile(string text, LogStatus status)
        {   
            if (IsNeedCreateNewFile())
                CreateLogFile();
            string[] fileNames = Directory.GetFiles(_filePath, $"{_fileMask}*");
            string lastFile = $"{_filePath}{_fileMask}{indexDevider}{GetLastIndexFile()}.log";
            using (System.IO.StreamWriter sw = File.AppendText(lastFile))
            {
                DateTime date = DateTime.Now;
                sw.WriteLine($"{date.TimeOfDay.ToString()}--{status} {text}");
            }
        }

        /// <summary>
        /// Check is path correct
        /// </summary>
        /// <param name="filePath">Example: C:\Test\LogDirecotry\</param>
        /// <returns></returns>
        private bool IsPathCorrect(string filePath)
        {
            string[] directories = filePath.Split('\\');
            string lastDir = directories[directories.Length - 1];
            if (lastDir.Contains('.'))
                return false;
            else if (filePath[filePath.Length - 1] != '\\')
                return false;
            return true;
        }

        /// <summary>
        /// Create directories to log file.
        /// Example: C:\Test\LogDirecotry\
        /// </summary>
        private void CreateDirectoriesToFile()
        {
            System.IO.Directory.CreateDirectory(_filePath);
        }

        private void CreateLogFile()
        {
            int fileIndex = GetLastIndexFile() + 1;
            DateTime date = DateTime.Now;
            string fileName = $"{_filePath}{_fileMask}";
            fileName = fileName.Replace(".", "");
            fileName = $"{fileName}{indexDevider}{fileIndex}.log";
            var myFile = File.Create(fileName);
            myFile.Close();
        }

        private int GetLastIndexFile()
        {
            int lastIndex = 0;
            int logIndex = 0;
            string[] fileNames = Directory.GetFiles(_filePath, $"{_fileMask}*");

            for (int fileNameIndex = 0; fileNameIndex < fileNames.Length; fileNameIndex++)
            {
                logIndex = GetLogIndexFromName(fileNames[fileNameIndex]);
                if (lastIndex < logIndex)
                    lastIndex = logIndex;
            }

            return lastIndex;
        }

        private int GetLogIndexFromName(string fileName)
        {
            string[] directories = fileName.Split('\\');
            string file = directories[directories.Length - 1];
            string indexStr = file.Substring(_fileMask.Length + 1);

            string index = string.Empty;
            for (int i = 0; i < indexStr.Length; i++)
            {
                if (indexStr[i] == '.')
                {
                    break;
                }
                index += indexStr[i];
            }

            return int.Parse(index);
        }
        
        private bool IsNeedCreateNewFile()
        {
            bool isNeed = false;
            string[] fileNames = Directory.GetFiles(_filePath,$"{_fileMask}*");
            Array.Sort(fileNames);
           
            if (fileNames.Length > 0 )
            {
                string lastFile = $"{_filePath}{_fileMask}{indexDevider}{GetLastIndexFile()}.log";
                FileInfo fi = new FileInfo(lastFile);//HERE!!!
                long lastFileSize = fi.Length;

                if (lastFileSize > MaxFileSize)
                    isNeed = true;
            }
            else if(fileNames.Length <= 0)
                isNeed = true;
            return isNeed;
        }

        public string Path
        {
            get { return _filePath; }
        }
    }

    public enum LogStatus
    {
        ERROR,
        WARNING,
        INFO
    }
}
