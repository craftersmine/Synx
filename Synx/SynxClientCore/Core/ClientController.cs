using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Synx.Client;

namespace craftersmine.Synx.Client.Core
{
    public sealed class ClientController
    {
        public delegate void OnOpenEventDelegate(object sender, EventArgs e);
        public delegate void OnCloseEventDelegate(object sender, WebSocketSharp.CloseEventArgs e);
        public delegate void OnErrorEventDelegate(object sender, WebSocketSharp.ErrorEventArgs e);
        public delegate void OnMessageEventDelegate(object sender, WebSocketSharp.MessageEventArgs e);
        public delegate void OnCreatingClientInstanceDelegate(object sender, EventArgs e);
        public delegate void OnCreatedClientInstanceDelegate(object sender, CreationEventDelegate e);
        public delegate void OnConnectingToServerDelegate(object sender, ConnectingToServerEventArgs e);

        public static event OnCreatingClientInstanceDelegate OnCreatingClientInstance;
        public static event OnCreatedClientInstanceDelegate OnCreatedClientInstance;
        public static event OnCloseEventDelegate OnClose;
        public static event OnErrorEventDelegate OnError;
        public static event OnMessageEventDelegate OnMessage;
        public static event OnOpenEventDelegate OnOpen;
        public static event OnConnectingToServerDelegate OnConnecting;

        public static void CreateClientInstance(string url, int port = 30203)
        {
            OnCreatingClientInstance?.Invoke(null, null);
            StaticData.LoggerInstance.Log("info", "Creating client instance...");
            string urlCtor = url + ":" + port;
            StaticData.LoggerInstance.Log("info", "Server URL for connection is \"" + urlCtor + "\"");
            StaticData.ClientInstance = new WebSocketSharp.WebSocket(urlCtor);
            StaticData.ClientInstance.OnClose += Client_OnClose;
            StaticData.ClientInstance.OnError += Client_OnError;
            StaticData.ClientInstance.OnMessage += Client_OnMessage;
            StaticData.ClientInstance.OnOpen += Client_OnOpen;
            StaticData.LoggerInstance.Log("info", "Client instance created!");
            OnCreatedClientInstance?.Invoke(null, new CreationEventDelegate() { IsSuccessful = true });
        }

        public static void InitializeConnection()
        {
            OnConnecting?.Invoke(null, new ConnectingToServerEventArgs() { Address = StaticData.ClientInstance.Url.Host, Port = StaticData.ClientInstance.Url.Port });
            StaticData.LoggerInstance.Log("info", "Connecting to \"" + StaticData.ClientInstance.Url + "\"...");
            StaticData.ClientInstance.Connect();
        }

        public static void CloseConnection()
        {
            StaticData.LoggerInstance.Log("info", "Disconnecting from \"" + StaticData.ClientInstance.Url + "\"...");
            StaticData.ClientInstance.CloseAsync();
        }

        private static void Client_OnOpen(object sender, EventArgs e)
        {
            StaticData.LoggerInstance.Log("info", "Connected to \"" + StaticData.ClientInstance.Url + "\"!");
            OnOpen?.Invoke(sender, e);
        }

        private static void Client_OnMessage(object sender, WebSocketSharp.MessageEventArgs e)
        {
            OnMessage?.Invoke(sender, e);   
        }

        private static void Client_OnError(object sender, WebSocketSharp.ErrorEventArgs e)
        {
            StaticData.LoggerInstance.Log("error", "An error in connection has occured! " + e.Message);
            StaticData.LoggerInstance.LogException("error", e.Exception);
            OnError?.Invoke(sender, e);
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
            OnClose.Invoke(sender, e);
        }
    }

    public class ConnectingToServerEventArgs
    {
        public string Address { get; set; }
        public int Port { get; set; }
    }

    public class CreationEventDelegate
    {
        public bool IsSuccessful { get; set; }
    }
}
