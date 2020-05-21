using System.Diagnostics;

namespace Dime.Logging
{
    [DebuggerStepThrough]
    public class Log4NetTraceListener : TraceListener
    {
        public Log4NetTraceListener()
        {
            Logger = new Logger();
        }

        private ILogger Logger { get; }

        [DebuggerStepThrough]
        public override void Write(string message) 
            => Logger.Debug(message, "TRACE");

        [DebuggerStepThrough]
        public override void WriteLine(string message) 
            => Logger.Debug(message, "TRACE");
    }
}