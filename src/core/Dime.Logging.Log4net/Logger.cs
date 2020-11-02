using log4net;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

namespace Dime.Logging
{
    public partial class Logger : ILogger
    {
        private readonly ILog _log;

        public Logger()
        {
            _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        }

        public Logger(string name)
        {
            _log = LogManager.GetLogger(name);
        }

        [DebuggerStepThrough]
        public void Debug(string message)
            => ThreadPool.QueueUserWorkItem(task => _log.Debug(message));

        [DebuggerStepThrough]
        public void Debug(string message, string category)
        {
            ThreadPool.QueueUserWorkItem(task =>
            {
                SetCategory(category);
                _log.Debug(message);
            });
        }

        [DebuggerStepThrough]
        public void Debug(string message, Exception ex)
            => ThreadPool.QueueUserWorkItem(task => _log.Debug(message, ex));

        [DebuggerStepThrough]
        public void Debug(string message, string category, Exception ex)
        {
            ThreadPool.QueueUserWorkItem(task =>
            {
                SetCategory(category);
                _log.Debug(message, ex);
            });
        }

        [DebuggerStepThrough]
        public void Information(string message)
            => ThreadPool.QueueUserWorkItem(task => _log.Info(message));

        [DebuggerStepThrough]
        public void Information(string message, string category)
        {
            ThreadPool.QueueUserWorkItem(task =>
            {
                SetCategory(category);
                _log.Info(message);
            });
        }

        [DebuggerStepThrough]
        public void Warning(string message)
            => ThreadPool.QueueUserWorkItem(task => _log.Warn(message));

        [DebuggerStepThrough]
        public void Warning(bool condition, string message)
        {
            if (condition)
                ThreadPool.QueueUserWorkItem(task => _log.Warn(message));
        }

        [DebuggerStepThrough]
        public void Warning(string message, string category)
        {
            ThreadPool.QueueUserWorkItem(task =>
            {
                SetCategory(category);
                _log.Warn(message);
            });
        }

        [DebuggerStepThrough]
        public void Warning(string message, string category, Exception ex)
        {
            ThreadPool.QueueUserWorkItem(task =>
            {
                SetCategory(category);
                _log.Warn(message, ex);
            });
        }

        [DebuggerStepThrough]
        public void Warning(string message, Exception ex)
            => ThreadPool.QueueUserWorkItem(task => _log.Warn(message, ex));

        [DebuggerStepThrough]
        public void Exception(string message, Exception ex)
            => ThreadPool.QueueUserWorkItem(task => _log.Error(message, ex));

        [DebuggerStepThrough]
        public void Exception(string message, string category, Exception ex)
        {
            ThreadPool.QueueUserWorkItem(task =>
            {
                SetCategory(category);
                _log.Error(message, ex);
            });
        }

        [DebuggerStepThrough]
        public void Fatal(string message, Exception ex)
            => ThreadPool.QueueUserWorkItem(task => _log.Fatal(message, ex));

        [DebuggerStepThrough]
        public void Fatal(string message, string category, Exception ex)
        {
            ThreadPool.QueueUserWorkItem(task =>
            {
                SetCategory(category);
                _log.Fatal(message, ex);
            });
        }

        private void SetCategory(string category)
            => LogicalThreadContext.Properties["Category"] = category;
    }
}