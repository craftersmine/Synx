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
using craftersmine.Synx.Server.Utils;
using System.IO;
using System.Net;

namespace craftersmine.Synx.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" SYNX SERVER (c) craftersmine 2018");
                Console.ResetColor();
                StaticData.ServerRoot = Environment.CurrentDirectory;
                StaticData.LogsPath = Path.Combine(StaticData.ServerRoot, "logs");
                StaticData.LoggerInstance = new Utils.Logger("synx-server");
                Log("info", "Initiating Synx server...");
                ServerEnvironment.InitiateEnvironment(StaticData.ServerRoot);
                ServerConfig.LoadConfig();
                StaticData.UserStorage = new UserStorage();
                StaticData.CommandParser = new CommandParser();
                CommandRegister.RegisterCommands();
                string serverIp = ServerConfig.GetString("bind-ip");
                if (serverIp != string.Empty && serverIp != null && serverIp != "")
                {
                    if (IPAddress.TryParse(serverIp, out IPAddress address))
                    {
                        ServerController.CreateServerInstance(address, ServerConfig.GetInt("port"));
                    }
                    else
                    {
                        throw new ArgumentException("The IP address for the binding has an invalid format! Check the server configuration!");
                    }
                }
                else ServerController.CreateServerInstance(IPAddress.Any, ServerConfig.GetInt("port"));
                ServerController.StartServer();
                while (StaticData.IsServerRunning)
                {
                    string inp = Console.ReadLine();
                    if (inp.ToLower() == "stop")
                        ServerController.StopServer();
                }
                Log("info", "Synx server was stopped!");
            }
            catch (Exception ex)
            {
                CrashHandler.HandleException(ex);
            }
        }

        public static void Log(string prefix, string contents)
        {
            StaticData.LoggerInstance.Log(prefix, contents);
        }
    }
}
