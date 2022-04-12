using System;

namespace ModularisTest.Exceptions
{
    public class JobLoggerNullMessageException : Exception
    {
        public JobLoggerNullMessageException() : base("Error or Warning or Message must be specified.")
        {

        }
    }
}