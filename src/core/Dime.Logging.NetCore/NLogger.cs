using Microsoft.Extensions.Logging;

namespace Dime.Logging
{
    public class NLogger : ILogger
    {
        private readonly ILogger<NLogger> _logger;

        public NLogger(ILogger<NLogger> logger)
        {
            _logger = logger;
        }

        private static string CategoryMessageTemplate => "[{category}]";
        private static string MessageTemplate => "{message}";

        public void Debug(string message)
            => _logger.LogDebug(message);

        public void Debug(string message, string category)
            => _logger.LogDebug($"{message} {CategoryMessageTemplate}", category);

        public void Debug(string message, Exception ex)
            => _logger.LogDebug(ex, message);

        public void Debug(string message, string category, Exception ex)
            => _logger.LogDebug($"{message} {CategoryMessageTemplate}", category, ex);

        public void Information(string message)
            => _logger.LogInformation(message);

        public void Information(string message, string category)
            => _logger.LogInformation($"{MessageTemplate} {CategoryMessageTemplate}", message, category);

        public void Warning(string message)
            => _logger.LogWarning(message);

        public void Warning(bool condition, string message)
        {
            if (condition)
                _logger.LogWarning(message);
        }

        public void Warning(string message, string category)
            => _logger.LogWarning($"{message} {CategoryMessageTemplate}", category);

        public void Warning(string message, Exception ex)
            => _logger.LogWarning(ex, message);

        public void Warning(string message, string category, Exception ex)
            => _logger.LogWarning(ex, $"{message} {CategoryMessageTemplate}", category);

        public void Exception(string message, Exception ex)
            => _logger.LogError(ex, message);

        public void Exception(string message, string category, Exception ex)
            => _logger.LogError(ex, $"{message} {CategoryMessageTemplate}", category);

        public void Fatal(string message, Exception ex)
            => _logger.LogCritical(ex, message);

        public void Fatal(string message, string category, Exception ex)
            => _logger.LogCritical($"{message} {CategoryMessageTemplate}", category, ex);
    }
}