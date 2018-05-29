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
        public delegate void OnMessageEventDelegate(object sender, OnMessageEventArgs e);
        public delegate void OnCreatingClientInstanceDelegate(object sender, EventArgs e);
        public delegate void OnCreatedClientInstanceDelegate(object sender, CreationEventArgs e);
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
            StaticData.LoggerInstance.Log(Utils.LogEntryType.Info, "Creating client instance...");
            string urlCtor = url + ":" + port;
            StaticData.LoggerInstance.Log(Utils.LogEntryType.Info, "Server URL for connection is \"" + urlCtor + "\"");
            StaticData.ClientInstance = new WebSocketSharp.WebSocket(urlCtor);
            StaticData.ClientInstance.OnClose += Client_OnClose;
            StaticData.ClientInstance.OnError += Client_OnError;
            StaticData.ClientInstance.OnMessage += Client_OnMessage;
            StaticData.ClientInstance.OnOpen += Client_OnOpen;
            StaticData.LoggerInstance.Log(Utils.LogEntryType.Done, "Client instance created!");
            OnCreatedClientInstance?.Invoke(null, new CreationEventArgs() { IsSuccessful = true });
        }

        public static void InitializeConnection()
        {
            OnConnecting?.Invoke(null, new ConnectingToServerEventArgs() { Address = StaticData.ClientInstance.Url.Host, Port = StaticData.ClientInstance.Url.Port });
            StaticData.LoggerInstance.Log(Utils.LogEntryType.Info, "Connecting to \"" + StaticData.ClientInstance.Url + "\"...");
            StaticData.ClientInstance.Connect();
        }

        public static void CloseConnection()
        {
            StaticData.LoggerInstance.Log(Utils.LogEntryType.Info, "Disconnecting from \"" + StaticData.ClientInstance.Url + "\"...");
            StaticData.ClientInstance.CloseAsync();
        }

        private static void Client_OnOpen(object sender, EventArgs e)
        {
            StaticData.LoggerInstance.Log(Utils.LogEntryType.Success, "Connected to \"" + StaticData.ClientInstance.Url + "\"!");
            OnOpen?.Invoke(sender, e);

            StaticData.ClientInstance.SendAsync(PacketBuilder(MessageType.Authorization, "REQUESTING_AUTH_REQUIREMENT"), new Action<bool>((b)=> { })); 
        }

        private static void Client_OnMessage(object sender, WebSocketSharp.MessageEventArgs e)
        {
            if (e.IsText)
            {
                string[] packetMetaSplit = e.Data.Split('#');
                if (packetMetaSplit[0] == "SYNX" && packetMetaSplit[2] == "PACKETEND")
                {
                    string[] packetDataSplit = packetMetaSplit[1].Split('$');

                    string packetType = packetDataSplit[0];
                    string packetData = packetDataSplit[1];
                    string packetAdditionals = packetDataSplit[2];

                    switch (packetType)
                    {
                        case "AUTHORIZATION":
                            if (packetData == "REQUESTING_AUTHORIZATION")
                                OnMessage?.Invoke(null, new OnMessageEventArgs() { MessageType = MessageType.Authorization, Data = e.Data});
                            break;
                        default:
                            OnMessage?.Invoke(null, new OnMessageEventArgs() { MessageType = MessageType.Unknown, Data = e.Data });
                            break;
                    }
                }
            }
            else if (e.IsBinary)
            {

            }
            else
            {

            }
        }

        private static void Client_OnError(object sender, WebSocketSharp.ErrorEventArgs e)
        {
            StaticData.LoggerInstance.Log(Utils.LogEntryType.Error, "An error in connection has occured! " + e.Message);
            StaticData.LoggerInstance.LogException(Utils.LogEntryType.Error, e.Exception);
            OnError?.Invoke(sender, e);
        }

        private static void Client_OnClose(object sender, WebSocketSharp.CloseEventArgs e)
        {
            StaticData.LoggerInstance.Log(Utils.LogEntryType.Info, "Closing connection to \"" + StaticData.ClientInstance.Url + "\"...");
            if (e.WasClean)
                StaticData.LoggerInstance.Log(Utils.LogEntryType.Info, "Connection to \"" + StaticData.ClientInstance.Url + "\" closed clearly!");
            else
            {
                StaticData.LoggerInstance.Log(Utils.LogEntryType.Warning, "Unable to close connection to \"" + StaticData.ClientInstance.Url + "\" clearly! Code: " + e.Code);
                StaticData.LoggerInstance.Log(Utils.LogEntryType.Warning, "Reason of disconnect: " + e.Reason);
            }
            StaticData.ClientInstance = null;
            OnClose.Invoke(sender, e);
        }

        private static string PacketBuilder(MessageType packetType, string packetData, string additionalData)
        {
            return "SYNX#" + packetType.ToString().ToUpper() + "$" + packetData + "$" + additionalData + "#PACKETEND";
        }
        
        private static string PacketBuilder(MessageType packetType, string packetData)
        {
            return PacketBuilder(packetType, packetData, "NO_ADDITIONAL_DATA_PROVIDED");
        }

        public static void SendPacket(MessageType messageType, string packetData)
        {
            StaticData.ClientInstance.SendAsync(PacketBuilder(messageType, packetData), new Action<bool>((b)=> { }));
        }

        public static void SendPacket(MessageType messageType, string packetData, string additionalData)
        {
            StaticData.ClientInstance.SendAsync(PacketBuilder(messageType, packetData, additionalData), new Action<bool>((b) => { }));
        }
    }

    public class ConnectingToServerEventArgs
    {
        public string Address { get; set; }
        public int Port { get; set; }
    }

    public class CreationEventArgs
    {
        public bool IsSuccessful { get; set; }
    }

    public class OnMessageEventArgs
    {
        public MessageType MessageType { get; set; }
        public string Data { get; set; }
    }

    public enum MessageType
    {
        Authorization, Unknown
    }
}
