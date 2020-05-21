using System;
using System.Threading.Tasks;

namespace Dime.Logging
{
    public interface ILoggerAsync
    {
        Task DebugAsync(string message);

        Task DebugAsync(string message, Exception ex);

        Task InformationAsync(string message);

        Task WarningAsync(string message);

        Task WarningAsync(string message, Exception ex);

        Task ExceptionAsync(string message, Exception ex);

        Task FatalAsync(string message, Exception ex);
    }
}