using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp.Server;
using WebSocketSharp;
using craftersmine.Packager.Lib.Core;
using craftersmine.Packager.Lib.Core.Exceptions;
using craftersmine.Synx.Server.Core;

namespace craftersmine.Synx.Server
{
    public sealed class StaticData
    {
        public static WebSocketServer ServerInstance { get; set; }
        public static Utils.Logger LoggerInstance { get; set; }
        public static UserStorage UserStorage { get; set; }
        public static CommandParser CommandParser { get; set; }

        public static string UserStorageFolderPath { get; set; }
        public static string LogsPath { get; set; }
        public static string ServerRoot { get; set; }
        public static string AccountsFilePath { get; set; }
        public static string BannedFilePath { get; set; }

        public static bool IsServerRunning { get; set; }
    }
}
