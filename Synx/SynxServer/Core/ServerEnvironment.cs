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
        private static Dictionary<string, string> predefinedConfig = new Dictionary<string, string>();

        public static void InitiateEnvironment(string serverRoot)
        {
            predefinedConfig.Add("port", "30203");
            predefinedConfig.Add("bind-ip", "");
            predefinedConfig.Add("motd", "Synx Server");
            predefinedConfig.Add("require-auth", "true");
            predefinedConfig.Add("allow-anonymous", "false");

            try
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
                    List<string> cfg = new List<string>();
                    foreach (var predefCfg in predefinedConfig)
                        cfg.Add(string.Join("=", predefCfg.Key, predefCfg.Value));
                    File.WriteAllLines(serverPropsFile, cfg);
                }
                else
                {
                    string[] lines = File.ReadAllLines(serverPropsFile);
                    List<string> toWrite = new List<string>();
                    List<string> keys = new List<string>();
                    foreach (var prop in lines)
                        keys.Add(prop.Split('=')[0]);
                    foreach (var key in predefinedConfig)
                    {
                        if (!keys.Contains(key.Key))
                        {
                            toWrite.Add(string.Join("=", key.Key, key.Value));
                        }
                    }
                    if (toWrite.Any())
                    {
                        toWrite.AddRange(lines);
                        File.WriteAllLines(serverPropsFile, toWrite);
                    }
                }
                if (!File.Exists(banlistFile))
                    File.WriteAllText(banlistFile, "");
                if (!File.Exists(accountsDataFile))
                    File.WriteAllText(accountsDataFile, "");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void Log(string prefix, string contents)
        {
            StaticData.LoggerInstance.Log(prefix, contents);
        }
    }
}
