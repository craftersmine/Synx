using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using craftersmine.Synx.Server.Utils;

namespace craftersmine.Synx.Server.Core
{
    public sealed class ServerConfig
    {
        private static Dictionary<string, string> cfg = new Dictionary<string, string>();

        public static void LoadConfig()
        {
            Program.Log("info", "Loading server configuration...");
            string[] file = File.ReadAllLines(Path.Combine(StaticData.ServerRoot, "server-properties.cfg"));
            foreach (var ln in file)
            {
                string[] kvp = ln.Split('=');
                cfg.Add(kvp[0], kvp[1]);
            }
        }

        public static string GetString(string key)
        {
            string val = "";
            if (cfg.TryGetValue(key, out val))
                return val;
            else throw new KeyNotFoundException("Config key \"" + key + "\" not found in file!");
        }
    }
}
