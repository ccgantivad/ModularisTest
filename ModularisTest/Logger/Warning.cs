using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularisTest.Logger
{
    public sealed class Warning : ILogger 
    {
        public string DoLogger()
        {            
            return this.ToString();
        }
        private Warning() { }
        private static Warning _instance;
        public static Warning GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Warning();
            }
            return _instance;
        }
    }
}
