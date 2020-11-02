using log4net.Core;
using log4net.Layout.Pattern;
using System.IO;
using System.Web;

namespace Dime.Logging
{
    public class HttpContextUserPatternConverter : PatternLayoutConverter
    {
        protected override void Convert(TextWriter writer, LoggingEvent loggingEvent)
        {
            HttpContext context = HttpContext.Current;

            string name = "";
            if (context?.User != null && context.User.Identity.IsAuthenticated)
                name = context.User.Identity.Name;

            writer.Write(name);
        }
    }
}