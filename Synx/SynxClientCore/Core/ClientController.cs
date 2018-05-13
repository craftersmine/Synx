using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace craftersmine.Synx.Client.Core
{
    public sealed class ClientController
    {
        public static void CreateClientInstance(string url, int port = 30203)
        {
            StaticData.LoggerInstance.Log("info", "Creating client instance...");
            string urlCtor = url + ":" + port;
            StaticData.LoggerInstance.Log("info", "Server URL for connection is \"" + urlCtor + "\"");
            StaticData.ClientInstance = new WebSocketSharp.WebSocket(urlCtor);
            StaticData.ClientInstance.OnClose += Client_OnClose;
            StaticData.ClientInstance.OnError += Client_OnError;
            StaticData.ClientInstance.OnMessage += Client_OnMessage;
            StaticData.ClientInstance.OnOpen += Client_OnOpen;
            StaticData.LoggerInstance.Log("info", "Client instance created!");
        }

        public static void InitializeConnection()
        {
            StaticData.LoggerInstance.Log("info", "Connecting to \"" + StaticData.ClientInstance.Url + "\"...");
            StaticData.ClientInstance.Connect();
        }

        private static void Client_OnOpen(object sender, EventArgs e)
        {
            StaticData.LoggerInstance.Log("info", "Connected to \"" + StaticData.ClientInstance.Url + "\"!");
        }

        private static void Client_OnMessage(object sender, WebSocketSharp.MessageEventArgs e)
        {
            
        }

        private static void Client_OnError(object sender, WebSocketSharp.ErrorEventArgs e)
        {
            StaticData.LoggerInstance.Log("error", "An error in connection has occured! " + e.Message);
            StaticData.LoggerInstance.LogException("error", e.Exception);
        }

        private static void Client_OnClose(object sender, WebSocketSharp.CloseEventArgs e)
        {
            StaticData.LoggerInstance.Log("info", "Closing connection to \"" + StaticData.ClientInstance.Url + "\"...");
            if (e.WasClean)
                StaticData.LoggerInstance.Log("info", "Connection to \"" + StaticData.ClientInstance.Url + "\" closed clearly!");
            else
            {
                StaticData.LoggerInstance.Log("warn", "Unable to close connection to \"" + StaticData.ClientInstance.Url + "\" clearly! Code: " + e.Code);
                StaticData.LoggerInstance.Log("warn", "Reason of disconnect: " + e.Reason);
            }
            StaticData.ClientInstance = null;
        }
    }
}
