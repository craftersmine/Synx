using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Packager.Lib.Core;
using craftersmine.Packager.Lib.Core.Exceptions;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace craftersmine.Synx.Server.Core
{
    public sealed class ServerBehaviour : WebSocketBehavior
    {
        /*
            Packet template:

            Standart packet: SYNX#[PACKETTYPE]$[PACKETDATA]$[ADDITIONALDATA]#PACKETEND
            File transfer packet (as bytes): SYNX#FILETP$[USERNAME]$[TOKEN]$%[4K_BYTES_OF_FILE]#PACKETEND
        */
        protected override void OnOpen()
        {
            Program.Log("info", "User connected to server! Requesting client user data...");
        }

        protected override void OnClose(CloseEventArgs e)
        {
            
        }

        protected override void OnError(ErrorEventArgs e)
        {
            
        }

        protected override void OnMessage(MessageEventArgs e)
        {
            Program.Log("info\\debug", e.Data);
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
                            switch(packetData)
                            {
                                case "REQUESTING_AUTH_REQUIREMENT":
                                    if (ServerConfig.GetBool("require-auth"))
                                        SendPacket(MessageType.Authorization, "REQUESTING_AUTHORIZATION");
                                    else SendPacket(MessageType.Authorization, "NO_AUTHORIZATION_REQUIRED");
                                    break;
                                case "AUTHORIZATION_RESPONSE_USERDATA":
                                    string[] parsedUserData = packetAdditionals.Split('!');
                                    string encPassword = parsedUserData[1];
                                    string username = parsedUserData[0];
                                    switch (StaticData.UserStorage.CheckUserCredentials(username, encPassword))
                                    {
                                        case UserCredentialsCheckResultType.UserNotFound:
                                            SendPacket(MessageType.Authorization, "USER_NOT_FOUND");
                                            break;
                                        case UserCredentialsCheckResultType.UserCredentialsCorrect:
                                            SendPacket(MessageType.Authorization, "USER_CREDENTIALS_CORRECT");
                                            break;
                                        case UserCredentialsCheckResultType.UserBanned:
                                            SendPacket(MessageType.Authorization, "USER_BANNED");
                                            break;
                                        case UserCredentialsCheckResultType.UserPasswordIncorrect:
                                            SendPacket(MessageType.Authorization, "USER_PASSWORD_INCORRECT");
                                            break;
                                    }
                                    break;
                            }
                            break;
                        default:

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

        private static string PacketBuilder(MessageType packetType, string packetData, string additionalData)
        {
            return "SYNX#" + packetType.ToString().ToUpper() + "$" + packetData + "$" + additionalData + "#PACKETEND";
        }

        private static string PacketBuilder(MessageType packetType, string packetData)
        {
            return PacketBuilder(packetType, packetData, "NO_ADDITIONAL_DATA_PROVIDED");
        }

        public void SendPacket(MessageType messageType, string packetData)
        {
            SendAsync(PacketBuilder(messageType, packetData), new Action<bool>((b) => { }));
        }

        public void SendPacket(MessageType messageType, string packetData, string additionalData)
        {
            SendAsync(PacketBuilder(messageType, packetData, additionalData), new Action<bool>((b) => { }));
        }
    }

    public enum MessageType
    {
        Authorization
    }
}
