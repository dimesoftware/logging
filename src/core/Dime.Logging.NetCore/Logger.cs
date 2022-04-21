using Microsoft.Extensions.Logging;

namespace Dime.Logging
{
    public class Logger : ILogger
    {
        private readonly ILogger<Logger> _logger;

        public Logger(ILogger<Logger> logger)
        {
            _logger = logger;
        }

        private static string FormatCategory(string category) => $"[{category}]";

        public void Debug(string message)
            => _logger.LogDebug(message);

        public void Debug(string message, string category)
            => _logger.LogDebug($"{FormatCategory(category)} {message}");

        public void Debug(string message, Exception ex)
            => _logger.LogDebug(ex, message);

        public void Debug(string message, string category, Exception ex)
            => _logger.LogDebug($"{FormatCategory(category)} {message}", ex);

        public void Information(string message)
            => _logger.LogInformation(message);

        public void Information(string message, string category)
            => _logger.LogInformation($"{FormatCategory(category)} {message}");

        public void Warning(string message)
            => _logger.LogWarning(message);

        public void Warning(bool condition, string message)
        {
            if (condition)
                _logger.LogWarning(message);
        }

        public void Warning(string message, string category)
            => _logger.LogWarning($"{FormatCategory(category)} {message}");

        public void Warning(string message, Exception ex)
            => _logger.LogWarning(ex, message);

        public void Warning(string message, string category, Exception ex)
            => _logger.LogWarning(ex, $"{FormatCategory(category)} {message}");

        public void Exception(string message, Exception ex)
            => _logger.LogError(ex, message);

        public void Exception(string message, string category, Exception ex)
            => _logger.LogError(ex, $"{FormatCategory(category)} {message}");

        public void Fatal(string message, Exception ex)
            => _logger.LogCritical(ex, message);

        public void Fatal(string message, string category, Exception ex)
            => _logger.LogCritical($"{FormatCategory(category)} {message}", ex);
    }
}