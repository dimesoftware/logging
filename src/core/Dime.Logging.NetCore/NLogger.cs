using Microsoft.Extensions.Logging;

namespace Dime.Logging
{
    public class NLogger : ILogger
    {
        private const string Message = $"{MessageTemplates.Message} {MessageTemplates.Category}";
        private readonly ILogger<NLogger> _logger;

        public NLogger(ILogger<NLogger> logger)
        {
            _logger = logger;
        }

        public void Debug(string message)
            => _logger.LogDebug(MessageTemplates.Message, message);

        public void Debug(string message, string category)
            => _logger.LogDebug(Message, message, category);

        public void Debug(string message, Exception ex)
            => _logger.LogDebug(ex, MessageTemplates.Message, message);

        public void Debug(string message, string category, Exception ex)
            => _logger.LogDebug(ex, Message, message, category);

        public void Information(string message)
            => _logger.LogInformation(MessageTemplates.Message, message);

        public void Information(string message, string category)
            => _logger.LogInformation(Message, message, category);

        public void Warning(string message)
            => _logger.LogWarning(MessageTemplates.Message, message);

        public void Warning(bool condition, string message)
        {
            if (condition)
                _logger.LogWarning(MessageTemplates.Message, message);
        }

        public void Warning(string message, string category)
            => _logger.LogWarning(Message, message, category);

        public void Warning(string message, Exception ex)
            => _logger.LogWarning(ex, MessageTemplates.Message, message);

        public void Warning(string message, string category, Exception ex)
            => _logger.LogWarning(ex, Message, message, category);

        public void Exception(string message, Exception ex)
            => _logger.LogError(ex, MessageTemplates.Message, message);

        public void Exception(string message, string category, Exception ex)
            => _logger.LogError(ex, Message, message, category);

        public void Fatal(string message, Exception ex)
            => _logger.LogCritical(ex, MessageTemplates.Message, message);

        public void Fatal(string message, string category, Exception ex)
            => _logger.LogCritical(ex, Message, message, category);
    }
}