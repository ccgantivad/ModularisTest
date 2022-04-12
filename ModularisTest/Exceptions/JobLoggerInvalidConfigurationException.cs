using System;

namespace ModularisTest.Exceptions
{
    public class JobLoggerInvalidConfigurationException : Exception
    {
        public JobLoggerInvalidConfigurationException() : base("Invalid configuration.")
        {

        }
    }
}