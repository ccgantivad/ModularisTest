using ModularisTest.Bussines;
using ModularisTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularisTest.Logger
{
    public sealed  class Error : ILogger
    {
        public void DoLogger( LoggerModel log)
        {
            Print print = Print.GetInstance();
            print.PrintMethod(log, "Error");            
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
