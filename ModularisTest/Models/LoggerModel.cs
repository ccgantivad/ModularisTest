using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularisTest.Models
{
    public sealed class LoggerModel
    {
        public string message { get; set; }   
        public bool logToFile { get; set; }
        public bool logToConsole { get; set; }

        private LoggerModel() { }
        private static LoggerModel _instance;
        public static LoggerModel GetInstance()
        {
            if (_instance == null)
            {
                _instance = new LoggerModel();
            }
            return _instance;
        }
    }
}
