using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Singleton_Library
{
    public class LoggerClass
    {
        private static LoggerClass instance;
        public List<string> info = new List<string>();
        private string logFilePath = "log.txt";

        private LoggerClass()
        {
        }

        public static LoggerClass getInstance()
        {
            if (instance == null)
            {
                instance = new LoggerClass();
            }
            return instance;
        }

        public void logging(string message)
        {
            string entry = $"[{DateTime.Now:HH:mm:ss}] {message}";
            info.Add(entry);

            try
            {
                File.AppendAllText(logFilePath, entry + Environment.NewLine);
            }
            catch
            {
            }
        }
    }
}