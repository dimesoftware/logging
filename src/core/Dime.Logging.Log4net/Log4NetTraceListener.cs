using System.Diagnostics;

namespace Dime.Logging
{
    /// <summary>
    ///
    /// </summary>
    [DebuggerStepThrough()]
    public class Log4NetTraceListener : TraceListener
    {
        #region Constructor

        /// <summary>
        ///
        /// </summary>
        public Log4NetTraceListener()
        {
            this.Logger = new Logger();
        }

        #endregion Constructor

        #region Properties

        private ILogger Logger { get; set; }

        #endregion Properties

        #region Methods

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        [DebuggerStepThrough()]
        public override void Write(string message)
        {
            this.Logger.Debug(message, "TRACE");
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        [DebuggerStepThrough()]
        public override void WriteLine(string message)
        {
            this.Logger.Debug(message, "TRACE");
        }

        #endregion Methods
    }
}