using ApiPrayaga.Application.Interfaces.Repository.NLog;
using NLog;
using ILogger = NLog.ILogger;

namespace ApiPrayaga.Application.Globals
{
    public class LoggerManager : ILoggerManager
    {
        private static ILogger _logger = LogManager.GetCurrentClassLogger();
        public void LogDebug(string message)
        {
            _logger.Debug(message);
        }

        public void LogError(string message)
        {
            _logger.Error(message);
        }

        public void LogInfo(string message)
        {
            _logger.Info(message);
        }

        public void LogWarnig(string message)
        {
            _logger.Warn(message);
        }
    }
}
