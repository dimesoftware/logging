using log4net;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;

namespace Dime.Logging
{
    /// <summary>
    ///
    /// </summary>
    /// <history>
    /// [HB] 05/02/2016- Review
    /// </history>
    public partial class Logger : ILogger, ILoggerAsync
    {
        #region Constructor

        /// <summary>
        ///
        /// </summary>
        /// <history>
        /// [HB] 05/02/2016- Review
        /// </history>
        public Logger()
        {
            this.Log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <history>
        /// [HB] 05/02/2016- Review
        /// </history>
        public Logger(string name)
        {
            this.Log = log4net.LogManager.GetLogger(name);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="configFile"></param>
        /// <history>
        /// [HB] 05/02/2016- Review
        /// </history>
        public Logger(string name, FileInfo configFile)
        {
            this.Log = log4net.LogManager.GetLogger(name);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="configFile"></param>
        /// <history>
        /// [HB] 05/02/2016- Review
        /// </history>
        public Logger(string name, string tenant)
        {
            this.Log = log4net.LogManager.GetLogger(name);
        }

        #endregion Constructor

        #region Properties

        private readonly ILog Log;

        #endregion Properties

        #region Methods

        #region Debug

        /// <summary>
        ///
        /// </summary>
        /// <history>
        /// [HB] 05/02/2016- Review
        /// </history>
        /// <param name="message"></param>
        [DebuggerStepThrough()]
        public void Debug(string message)
        {
            ThreadPool.QueueUserWorkItem(task =>
            {
                this.Log.Debug(message);
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="category"></param>
        /// <history>
        /// [HB] 05/02/2016- Review & Bug Fix
        /// </history>
        [DebuggerStepThrough()]
        public void Debug(string message, string category)
        {
            ThreadPool.QueueUserWorkItem(task =>
            {
                this.SetCategory(category);
                this.Log.Debug(message);
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <history>
        /// [HB] 05/02/2016- Review
        /// </history>
        [DebuggerStepThrough()]
        public void Debug(string message, Exception ex)
        {
            ThreadPool.QueueUserWorkItem(task =>
            {
                this.Log.Debug(message, ex);
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="category"></param>
        /// <param name="ex"></param>
        /// <history>
        /// [HB] 05/02/2016- Review
        /// </history>
        [DebuggerStepThrough()]
        public void Debug(string message, string category, Exception ex)
        {
            ThreadPool.QueueUserWorkItem(task =>
            {
                this.SetCategory(category);
                this.Log.Debug(message, ex);
            });
        }

        #endregion Debug

        #region Information

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <history>
        /// [HB] 05/02/2016- Review
        /// </history>
        [DebuggerStepThrough()]
        public void Information(string message)
        {
            ThreadPool.QueueUserWorkItem(task =>
            {
                this.Log.Info(message);
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="category"></param>
        /// <history>
        /// [HB] 05/02/2016- Review
        /// </history>
        [DebuggerStepThrough()]
        public void Information(string message, string category)
        {
            ThreadPool.QueueUserWorkItem(task =>
            {
                this.SetCategory(category);
                this.Log.Info(message);
            });
        }

        #endregion Information

        #region Warning

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <history>
        /// [HB] 05/02/2016- Review
        /// </history>
        [DebuggerStepThrough()]
        public void Warning(string message)
        {
            ThreadPool.QueueUserWorkItem(task =>
            {
                this.Log.Warn(message);
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>        
        [DebuggerStepThrough()]
        public void Warning(bool condition, string message)
        {
            if (condition)
                ThreadPool.QueueUserWorkItem(task => this.Log.Warn(message));
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="category"></param>
        /// <history>
        /// [HB] 05/02/2016- Review
        /// </history>
        [DebuggerStepThrough()]
        public void Warning(string message, string category)
        {
            ThreadPool.QueueUserWorkItem(task =>
            {
                this.SetCategory(category);
                this.Log.Warn(message);
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="category"></param>
        /// <param name="ex"></param>
        /// <history>
        /// [HB] 05/02/2016- Review
        /// </history>
        [DebuggerStepThrough()]
        public void Warning(string message, string category, Exception ex)
        {
            ThreadPool.QueueUserWorkItem(task =>
            {
                this.SetCategory(category);
                this.Log.Warn(message, ex);
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <history>
        /// [HB] 05/02/2016- Review
        /// </history>
        [DebuggerStepThrough()]
        public void Warning(string message, Exception ex)
        {
            ThreadPool.QueueUserWorkItem(task =>
            {
                this.Log.Warn(message, ex);
            });
        }

        #endregion Warning

        #region Exception

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <history>
        /// [HB] 05/02/2016- Review
        /// </history>
        [DebuggerStepThrough()]
        public void Exception(string message, Exception ex)
        {
            ThreadPool.QueueUserWorkItem(task =>
            {
                this.Log.Error(message, ex);
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="category"></param>
        /// <param name="ex"></param>
        /// <history>
        /// [HB] 05/02/2016- Review
        /// </history>
        [DebuggerStepThrough()]
        public void Exception(string message, string category, Exception ex)
        {
            ThreadPool.QueueUserWorkItem(task =>
            {
                this.SetCategory(category);
                this.Log.Error(message, ex);
            });
        }

        #endregion Exception

        #region Fatal

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <history>
        /// [HB] 05/02/2016- Review
        /// </history>
        [DebuggerStepThrough()]
        public void Fatal(string message, Exception ex)
        {
            ThreadPool.QueueUserWorkItem(task =>
            {
                this.Log.Fatal(message, ex);
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="category"></param>
        /// <param name="ex"></param>
        /// <history>
        /// [HB] 05/02/2016- Review
        /// </history>
        [DebuggerStepThrough()]
        public void Fatal(string message, string category, Exception ex)
        {
            ThreadPool.QueueUserWorkItem(task =>
            {
                this.SetCategory(category);
                this.Log.Fatal(message, ex);
            });
        }

        #endregion Fatal

        #region Helpers

        /// <summary>
        ///
        /// </summary>
        /// <param name="category"></param>
        /// <history>
        /// [HB] 05/02/2016- Review
        /// </history>
        private void SetCategory(string category)
        {
            log4net.LogicalThreadContext.Properties["Category"] = category;
        }

        #endregion Helpers

        #endregion Methods
    }
}