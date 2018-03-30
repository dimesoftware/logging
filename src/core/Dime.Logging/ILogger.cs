using System;

namespace Dime.Logging
{
    /// <summary>
    ///
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        void Debug(string message);

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="category"></param>
        void Debug(string message, string category);

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        void Debug(string message, Exception ex);

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="category"></param>
        /// <param name="ex"></param>
        void Debug(string message, string category, Exception ex);

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        void Information(string message);

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="category"></param>
        void Information(string message, string category);

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        void Warning(string message);

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        void Warning(bool condition, string message);

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="category"></param>
        void Warning(string message, string category);

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        void Warning(string message, Exception ex);

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="category"></param>
        /// <param name="ex"></param>
        void Warning(string message, string category, Exception ex);

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        void Exception(string message, Exception ex);

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="category"></param>
        /// <param name="ex"></param>
        void Exception(string message, string category, Exception ex);

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        void Fatal(string message, Exception ex);

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="category"></param>
        /// <param name="ex"></param>
        void Fatal(string message, string category, Exception ex);
    }
}