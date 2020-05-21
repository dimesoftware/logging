using System;
using System.Threading.Tasks;

namespace Dime.Logging
{
    public partial class Logger : ILoggerAsync
    {
        public Task DebugAsync(string message)
            => Task.Run(() => _log.Debug(message));

        public Task DebugAsync(string message, Exception ex)
            => Task.Run(() => _log.Debug(message, ex));

        public Task InformationAsync(string message)
            => Task.Run(() => _log.Info(message));

        public Task WarningAsync(string message)
            => Task.Run(() => _log.Warn(message));

        public Task WarningAsync(string message, Exception ex)
            => Task.Run(() => _log.Warn(message, ex));

        public Task ExceptionAsync(string message, Exception ex)
            => Task.Run(() => _log.Error(message, ex));

        public Task FatalAsync(string message, Exception ex)
            => Task.Run(() => _log.Fatal(message, ex));
    }
}