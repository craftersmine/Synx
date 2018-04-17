using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace craftersmine.Synx.Server.Core
{
    public sealed class ServerEnvironment
    {
        public static void InitiateEnvironment(string serverRoot)
        {
            Log("info", "Initiating server environment...");
            StaticData.UserStorage = Path.Combine(serverRoot, "user-storage");
            string serverPropsFile = Path.Combine(serverRoot, "server-properties.cfg");
            string banlistFile = Path.Combine(serverRoot, "banned-accounts.lst");
            string accountsDataFile = Path.Combine(serverRoot, "accounts-data.lst");
            if (!Directory.Exists(StaticData.UserStorage))
                Directory.CreateDirectory(StaticData.UserStorage);
            if (!File.Exists(serverPropsFile))
            {
                List<string> props = new List<string>();
                props.Add("port=30203");
                props.Add("bind-ip=");
                props.Add("motd=Synx Server");
                props.Add("require-auth=true");
                props.Add("allow-anonymous=false");
                File.WriteAllLines(serverPropsFile, props);
            }
            if (!File.Exists(banlistFile))
                File.WriteAllText(banlistFile, "");
            if (!File.Exists(accountsDataFile))
                File.WriteAllText(accountsDataFile, "");
        }

        private static void Log(string prefix, string contents)
        {
            StaticData.LoggerInstance.Log(prefix, contents);
        }
    }
}
