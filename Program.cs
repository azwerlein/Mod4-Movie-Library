using NLog;

namespace MovieLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory() + "\\nlog.config";

            Logger logger = LogManager.LoadConfiguration(path).GetCurrentClassLogger();

            logger.Info("Hello from info!");
            logger.Error("Hello from error!");
            logger.Trace("Hello from trace!");
        }
    }
}
