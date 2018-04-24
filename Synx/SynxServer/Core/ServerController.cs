using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace craftersmine.Synx.Server.Core
{
    public sealed class ServerController
    {
        public static void CreateServerInstance(IPAddress boundIp, int port)
        {
            Program.Log("info", "Creating server instance...");
            Program.Log("info", "Server instance bound with " + boundIp + ":" + port);
            StaticData.ServerInstance = new WebSocketSharp.Server.WebSocketServer(boundIp, port);
            StaticData.ServerInstance.AddWebSocketService<ServerBehaviour>("/");
        }

        public static void StartServer()
        {
            Program.Log("info", "Starting server instance...");
            StaticData.ServerInstance.Start();
            StaticData.IsServerRunning = StaticData.ServerInstance.IsListening;
            if (StaticData.IsServerRunning)
                Program.Log("info", "Server instance started!");
            else Program.Log("warning", "The server instance couldn't be initialized properly!");
        }

        public static void StopServer()
        {
            Program.Log("info", "Stopping server instance...");
            StaticData.ServerInstance.Stop();
            StaticData.IsServerRunning = StaticData.ServerInstance.IsListening;
            if (!StaticData.IsServerRunning)
                Program.Log("info", "Server instance stopped!");
            else Program.Log("warning", "The server instance couldn't be stopped properly!");
        }
    }
}
