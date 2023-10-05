using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPatternLoggingSystem
{
    public class InfoLogger : Logger
    {
        public InfoLogger() : base(LogLevel.Info) { }
        protected override void WriteMessage(string message)
        {
            Console.WriteLine("Info: " + message);
        }
    }

}
