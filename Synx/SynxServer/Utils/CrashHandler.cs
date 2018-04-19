using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace craftersmine.Synx.Server.Utils
{
    public sealed class CrashHandler
    {
        public static void HandleException(Exception exception)
        {
            logException("error", exception);
            Environment.Exit(0);
        }

        private static void logException(string prefix, Exception ex)
        {
            StaticData.LoggerInstance.LogException(prefix, ex);
        }
    }
}
