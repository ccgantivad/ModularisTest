using ModularisTest.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularisTest.Bussines
{
    public sealed class Print
    {
        private Print() { }
        private static Print _instance;
        public static Print GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Print();
            }
            return _instance;
        }

        public void PrintMethod(LoggerModel loggerModel, string type)
        {

            if (loggerModel.logToConsole)
            {
                PrintConsole(loggerModel.message, type);
            }
            if (loggerModel.logToFile)
            {
                PrintFile(loggerModel.message,type);
            }
        }

        public void PrintFile(string message, string type)
        {

            string l = string.Empty;
            var logFolder = ConfigurationManager.AppSettings["LogFileDirectory"];
            if (string.IsNullOrEmpty(logFolder)) logFolder = Environment.CurrentDirectory;
            var logFileName = "LogFile" + DateTime.Now.ToShortDateString().Replace("/", ".") + ".txt";
            var logFullFilePath = Path.Combine(logFolder, logFileName);

            if (File.Exists(logFullFilePath))
            {
                l = File.ReadAllText(logFullFilePath);
            }
            l = l + DateTime.Now.ToShortDateString() +" " +type+" " + message + Environment.NewLine;
            if (!Directory.Exists(logFolder)) Directory.CreateDirectory(logFolder);
            File.WriteAllText(logFullFilePath, l);
        }
        public void PrintConsole(string message, string type)
        {
            switch (type)
            {
                case "Error":

                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case "Warning":

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;

                case "Message":

                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    break;
            }
            Console.WriteLine(DateTime.Now.ToShortDateString() +" "+ message);

        }
    }
}
