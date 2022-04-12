using ModularisTest.Exceptions;
using ModularisTest.Logger;
using ModularisTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularisTest.Logic
{
    public sealed class Logger
    {
        private ILogger _logger;
        private static Logger _instance;
        public Logger()
        {

        }
        public void SetLogger(ILogger logger)
        {
            _logger = logger;
        }
        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }
        public string Log(LoggerModel log)
        {
             string result = Validate(log)? _logger.DoLogger(): null;
            return result;
        }

        public bool Validate(LoggerModel log)
        {
            bool flag = false;
            flag = ValidateNullMessage(log.message);
            flag = ValidateConfiguration(log);
            return flag;
        }
        public bool ValidateNullMessage(string message)
        {

            if (message == null || message.Length == 0)
            {
                throw new JobLoggerNullMessageException();
            }
            return true;
        }
        public bool ValidateConfiguration(LoggerModel log)
        {

            if (!log.logToConsole && !log.logToFile)
            {
                throw new JobLoggerInvalidConfigurationException();
            }
            return true;
        }

    }
}
