using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPatternLoggingSystem
{
    //Abstract Handler
    public abstract class Logger
    {
        protected Logger nextLogger;
        protected LogLevel logMask;
        public Logger(LogLevel mask)
        {
            this.logMask = mask;
        }
        public void SetNext(Logger nextLogger)
        {
            this.nextLogger = nextLogger;
        }
        public void LogMessage(LogLevel severity, string message)
        {
            if ((severity & logMask) != 0)
            {
                WriteMessage(message);
            }
            if (nextLogger != null)
            {
                nextLogger.LogMessage(severity, message);
            }
        }
        protected abstract void WriteMessage(string msg);
    }
}
