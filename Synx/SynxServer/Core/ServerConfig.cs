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
            if (cfg.TryGetValue(key, out string val))
                return val;
            else throw new KeyNotFoundException("Config key \"" + key + "\" not found in file! Check server environment integrity!");
        }

        public static int GetInt(string key)
        {
            if (cfg.TryGetValue(key, out string val))
            {
                if (int.TryParse(val, out int intVal))
                    return intVal;
                else throw new InvalidDataException("Config key \"" + key + "\" has invalid type, expected value is numeric value! Check your server config!");
            }
            else throw new KeyNotFoundException("Config key \"" + key + "\" not found in file! Check server environment integrity!");
        }

        public static long GetLong(string key)
        {
            if (cfg.TryGetValue(key, out string val))
            {
                if (long.TryParse(val, out long intVal))
                    return intVal;
                else throw new InvalidDataException("Config key \"" + key + "\" has invalid type, expected value is long numeric value! Check your server config!");
            }
            else throw new KeyNotFoundException("Config key \"" + key + "\" not found in file! Check server environment integrity!");
        }

        public static bool GetBool(string key)
        {
            if (cfg.TryGetValue(key, out string val))
            {
                if (bool.TryParse(val, out bool boolVal))
                    return boolVal;
                else throw new InvalidDataException("Config key \"" + key + "\" has invalid type, expected value is \"true\" or \"false\"! Check your server config!");
            }
            else throw new KeyNotFoundException("Config key \"" + key + "\" not found in file! Check server environment integrity!");
        }
    }
}
