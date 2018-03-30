using System;
using System.Threading.Tasks;

namespace Dime.Logging
{
    public interface ILoggerAsync
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        Task DebugAsync(string message);

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        Task DebugAsync(string message, Exception ex);

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        Task InformationAsync(string message);

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        Task WarningAsync(string message);

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        Task WarningAsync(string message, Exception ex);

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        Task ExceptionAsync(string message, Exception ex);

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        Task FatalAsync(string message, Exception ex);
    }
}