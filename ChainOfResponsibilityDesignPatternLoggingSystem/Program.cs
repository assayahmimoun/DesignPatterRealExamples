namespace ChainOfResponsibilityDesignPatternLoggingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Setting up the chain
            Logger debugLogger = new DebugLogger();
            Logger infoLogger = new InfoLogger();
            Logger errorLogger = new ErrorLogger();
            debugLogger.SetNext(infoLogger);
            infoLogger.SetNext(errorLogger);
            debugLogger.LogMessage(LogLevel.Debug, "This is a Debug Message.");
            debugLogger.LogMessage(LogLevel.Info, "System is Operating Normally.");
            debugLogger.LogMessage(LogLevel.Error, "System Encountered an Error!");
            Console.ReadLine();
        }
    }
}