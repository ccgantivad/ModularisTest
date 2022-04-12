using ModularisTest.Bussines;
using ModularisTest.Models;

namespace ModularisTest.Logger
{
    public sealed class Warning : ILogger 
    {
        public void DoLogger(LoggerModel log)
        {
            Print print = Print.GetInstance();
            print.PrintMethod(log, "Message");
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
