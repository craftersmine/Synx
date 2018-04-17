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
using System.IO;

namespace craftersmine.Synx.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticData.ServerRoot = Environment.CurrentDirectory;
            StaticData.LogsPath = Path.Combine(StaticData.ServerRoot, "logs");
            StaticData.LoggerInstance = new Utils.Logger("synx-server");
            Log("info", "Initiating server...");
            ServerEnvironment.InitiateEnvironment(StaticData.ServerRoot);
            Console.ReadKey();
        }

        protected static void Log(string prefix, string contents)
        {
            StaticData.LoggerInstance.Log(prefix, contents);
        }
    }
}
