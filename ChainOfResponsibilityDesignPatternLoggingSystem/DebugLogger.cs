using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPatternLoggingSystem
{
    //Concrete Handlers
    public class DebugLogger : Logger
    {
        public DebugLogger() : base(LogLevel.Debug) { }
        protected override void WriteMessage(string message)
        {
            Console.WriteLine("Debug: " + message);
        }
    }
}
