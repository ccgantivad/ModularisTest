using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularisTest.Logger
{
    public sealed  class Error : ILogger
    {
        public string DoLogger()
        {         
            return this.ToString();
        }

        private Error() { }
        private static Error _instance;
        public static Error GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Error();
            }
            return _instance;
        }

    }
}
