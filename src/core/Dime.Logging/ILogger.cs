using System;

namespace Dime.Logging
{
    /// <summary>
    ///
    /// </summary>
    public interface ILogger
    {
        void Debug(string message);

        void Debug(string message, string category);

        void Debug(string message, Exception ex);

        void Debug(string message, string category, Exception ex);

        void Information(string message);

        void Information(string message, string category);

        void Warning(string message);

        void Warning(bool condition, string message);

        void Warning(string message, string category);

        void Warning(string message, Exception ex);

        void Warning(string message, string category, Exception ex);

        void Exception(string message, Exception ex);

        void Exception(string message, string category, Exception ex);

        void Fatal(string message, Exception ex);

        void Fatal(string message, string category, Exception ex);
    }
}