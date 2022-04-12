using ModularisTest.Bussines;
using ModularisTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularisTest.Logger
{
    public sealed class Message : ILogger
    {
        public void DoLogger (LoggerModel log)
        {
            Print print = Print.GetInstance();
            print.PrintMethod(log, "Message");
        }
        private Message() { }
        private static Message _instance;
        public static Message GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Message();
            }
            return _instance;
        }

    }
}
