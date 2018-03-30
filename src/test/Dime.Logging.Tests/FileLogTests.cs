using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Dime.Logging.UnitTest
{
    [TestClass]
    [DeploymentItem("app.config")]
    public class FileLogTests
    {
        #region Constructor

        public FileLogTests()
        {
        }

        #endregion Constructor

        #region Properties

        public ILoggerAsync Logger { get; set; }
        private string ExpectedFile { get; set; }
        public string LogName { get; set; }

        #endregion Properties

        #region Methods
        
        [TestInitialize]
        public void Init()
        {
            this.LogName = "Trace Logger";
            this.Logger = new Logger(this.LogName);

            string logFileName = $"{DateTime.Now.ToString("yyyy-MM-dd")}-TracingLogs.log";
            this.ExpectedFile = Path.Combine(Environment.CurrentDirectory, "App_Data\\Logs", logFileName);

            if (File.Exists(this.ExpectedFile))
            {
                File.Delete(this.ExpectedFile);
            }
        }
              
        [TestMethod]
        [TestCategory("Logger")]
        public void Log_Information_WritesToDisk_ExpectSuccess()
        {
            string severity = "INFO";
            string logText = "WHOOPSIE DAYSIE";

            this.EvaluateLogOutput(this.Logger.InformationAsync(logText), logText, severity);
        }
        
        [TestMethod]
        [TestCategory("Logger")]
        public void Log_Debug_WritesToDisk_ExpectSuccess()
        {
            string severity = "DEBUG";
            string logText = "WHOOPSIE DAYSIE";

            this.EvaluateLogOutput(this.Logger.DebugAsync(logText), logText, severity);
        }
        
        [TestMethod]
        [TestCategory("Logger")]
        public void Log_Warning_WritesToDisk_ExpectSuccess()
        {
            string severity = "WARN";
            string logText = "WHOOPSIE DAYSIE";

            this.EvaluateLogOutput(this.Logger.WarningAsync(logText), logText, severity);
        }
        
        [TestMethod]
        [TestCategory("Logger")]
        public void Log_Error_WritesToDisk_ExpectSuccess()
        {
            string severity = "ERROR";
            string logText = "WHOOPSIE DAYSIE";
            Exception randomException = new Exception("");

            this.EvaluateLogOutput(this.Logger.ExceptionAsync(logText, randomException), logText, severity);
        }
       
        [TestMethod]
        [TestCategory("Logger")]
        public void Log_Fatal_WritesToDisk_ExpectSuccess()
        {
            string severity = "FATAL";
            string logText = "WHOOPSIE DAYSIE";
            Exception randomException = new Exception("");

            this.EvaluateLogOutput(this.Logger.FatalAsync(logText, randomException), logText, severity);
        }

        [TestMethod]
        [TestCategory("Logger")]
        public void LogName_ExpectSuccess()
        {
            string logText = "WHOOPSIE DAYSIE";
            this.EvaluateLogOutput(this.Logger.InformationAsync(logText), logText);
        }
       
        private void EvaluateLogOutput(Task logTask, string expectedLogText, string severity)
        {
            string output = this.GetLogOutPut(logTask);
            Assert.IsTrue(output.Contains(expectedLogText));
            Assert.IsTrue(output.Contains(severity));
        }
       
        private void EvaluateLogOutput(Task logTask, string expectedLogText)
        {
            string output = this.GetLogOutPut(logTask);
            Assert.IsTrue(output.Contains(expectedLogText));
        }
        
        private string GetLogOutPut(Task logTask)
        {
            Task<string> output = logTask.ContinueWith((x) =>
            {
                using (var fileStream = new FileStream(this.ExpectedFile, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    using (var streamReader = new StreamReader(fileStream))
                    {
                        string logText = streamReader.ReadToEnd();
                        return logText;
                    }
                }
            });

            return output.Result;
        }

        #endregion Methods
    }
}