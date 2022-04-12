using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularisTest.Logger
{
    public sealed class Message : ILogger
    {
        public string DoLogger()
        {            
            return this.ToString();
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
