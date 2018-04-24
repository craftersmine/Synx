using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp.Server;
using WebSocketSharp;
using craftersmine.Packager.Lib.Core;
using craftersmine.Packager.Lib.Core.Exceptions;

namespace craftersmine.Synx.Server
{
    public sealed class StaticData
    {
        public static WebSocketServer ServerInstance { get; set; }
        public static Utils.Logger LoggerInstance { get; set; }

        public static string UserStorage { get; set; }
        public static string LogsPath { get; set; }
        public static string ServerRoot { get; set; }

        public static bool IsServerRunning { get; set; }
    }
}
