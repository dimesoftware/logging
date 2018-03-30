using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Dime.Logging
{
    public partial class Logger : ILogger
    {
        #region Methods

        /// <summary>
        /// Logs the debug asynchronous.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        /// <history>
        /// [HB] 13/09/2015 - Create
        /// </history>
        [DebuggerStepThrough()]
        public Task DebugAsync(string message)
        {
            Task logTask = Task.Run(() =>
            {
                this.Log.Debug(message);
            });
            return logTask;
        }

        /// <summary>
        /// Logs the debug asynchronous.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="ex">The ex.</param>
        /// <returns></returns>
        /// <history>
        /// [HB] 13/09/2015 - Create
        /// </history>
        [DebuggerStepThrough()]
        public Task DebugAsync(string message, Exception ex)
        {
            Task logTask = Task.Run(() =>
            {
                this.Log.Debug(message, ex);
            });
            return logTask;
        }

        /// <summary>
        /// Logs the information asynchronous.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        /// <history>
        /// [HB] 13/09/2015 - Create
        /// </history>
        [DebuggerStepThrough()]
        public Task InformationAsync(string message)
        {
            Task logTask = Task.Run(() =>
           {
               this.Log.Info(message);
           });

            return logTask;
        }

        /// <summary>
        /// Logs the warning asynchronous.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        /// <history>
        /// [HB] 13/09/2015 - Create
        /// </history>
        [DebuggerStepThrough()]
        public Task WarningAsync(string message)
        {
            Task logTask = Task.Run(() =>
            {
                this.Log.Warn(message);
            });
            return logTask;
        }

        /// <summary>
        /// Logs the warning asynchronous.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="ex">The ex.</param>
        /// <returns></returns>
        /// <history>
        /// [HB] 13/09/2015 - Create
        /// </history>
        [DebuggerStepThrough()]
        public Task WarningAsync(string message, Exception ex)
        {
            Task logTask = Task.Run(() =>
            {
                this.Log.Warn(message, ex);
            });
            return logTask;
        }

        /// <summary>
        /// Logs the exception asynchronous.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="ex">The ex.</param>
        /// <returns></returns>
        /// <history>
        /// [HB] 13/09/2015 - Create
        /// </history>
        [DebuggerStepThrough()]
        public Task ExceptionAsync(string message, Exception ex)
        {
            Task logTask = Task.Run(() =>
            {
                this.Log.Error(message, ex);
            });
            return logTask;
        }

        /// <summary>
        /// Logs the fatal exception asynchronous.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="ex">The ex.</param>
        /// <returns></returns>
        /// <history>
        /// [HB] 13/09/2015 - Create
        /// </history>
        [DebuggerStepThrough()]
        public Task FatalAsync(string message, Exception ex)
        {
            Task logTask = Task.Run(() =>
            {
                this.Log.Fatal(message, ex);
            });
            return logTask;
        }

        #endregion Methods
    }
}