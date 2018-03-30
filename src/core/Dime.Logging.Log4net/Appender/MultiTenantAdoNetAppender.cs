using log4net.Appender;
using log4net.Core;
using System;
using System.Data;

namespace Dime.Logging
{
    public class MultiTenantAdoNetAppender : AdoNetAppender
    {
        #region Constructor

        public MultiTenantAdoNetAppender()
        {
        }

        public MultiTenantAdoNetAppender(string tenant)
        {
            this.CommandText = this.CommandText.Replace("[dbo]", string.Format("[{0}]", tenant));
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        ///
        /// </summary>
        /// <param name="loggingEvent"></param>
        protected override void Append(LoggingEvent loggingEvent)
        {
            base.Append(loggingEvent);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="connectionStringContext"></param>
        /// <returns></returns>
        protected override string ResolveConnectionString(out string connectionStringContext)
        {
            return base.ResolveConnectionString(out connectionStringContext);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="connectionType"></param>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        protected override IDbConnection CreateConnection(Type connectionType, string connectionString)
        {
            return base.CreateConnection(connectionType, connectionString);
        }

        #endregion Methods
    }
}