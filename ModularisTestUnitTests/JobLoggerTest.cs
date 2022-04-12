using ModularisTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModularisTest.Models;

namespace ModularisTestUnitTests
{
    [TestClass]
    public class JobLoggerTest
    {
        private const string TestMessage = "Test Message";
        private const string WarningMessage = "Test Warning";
        private const string ErrorMessage = "Test Error";

        [TestMethod]
        public void JobLoggerBasicTest()
        {
            JobLogger jobLogger = JobLogger.GetInstance();
            LoggerModel log = LoggerModel.GetInstance();
            log.logToConsole = true;
            log.logToFile = true;
            log.message = TestMessage;

            jobLogger.LogMessage(log);
            
           
        }
    }
}