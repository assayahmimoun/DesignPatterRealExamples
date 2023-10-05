using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPatternLoggingSystem
{
    public class ErrorLogger : Logger
    {
        public ErrorLogger() : base(LogLevel.Error) { }
        protected override void WriteMessage(string message)
        {
            Console.WriteLine("Error: " + message);
        }
    }
}
