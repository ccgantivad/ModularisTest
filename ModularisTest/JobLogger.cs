using ModularisTest.Exceptions;
using ModularisTest.Logger;
using ModularisTest.Logic;
using ModularisTest.Models;
using ModularisTest.Bussines;
using System;
using System.Configuration;
using System.IO;

namespace ModularisTest
{
    public class JobLogger
    {
        private JobLogger() { }
        private static JobLogger _instance;
        public static JobLogger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new JobLogger();
            }
            return _instance;
        }
        private static void Log(LoggerModel log, string Type)
        {
            ILogger _logger = null;
            Logic.Logger logger = Logic.Logger.GetInstance();
            switch (Type)
            {
                case "Message":
                    _logger = Message.GetInstance();
                    break;
                case "Warning":
                    _logger = Warning.GetInstance();
                    break;
                case "Error":
                    _logger = Error.GetInstance();
                    break;
                default:
                    break;
            }
            logger.SetLogger(_logger);
            logger.Log(log);
            Print print=Print.GetInstance();
            if (!String.IsNullOrEmpty(Type)) print.PrintMethod(log, Type);

        }

        public  void LogError(LoggerModel error)
        {
            Log(error, "Error");

        }
        public  void LogWarning(LoggerModel warning)
        {
            Log(warning, "Warning");

        }
        public  void LogMessage(LoggerModel message)
        {
            Log(message, "Message");

        }

      
    }
}