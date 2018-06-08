using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using craftersmine.Synx.Client;
using craftersmine.Synx.Client.Properties;
using craftersmine.Packager.Lib.Core;

namespace craftersmine.Synx.Client.App
{
    public sealed class StaticData
    {
        internal static Settings ClientSettings { get; } = new Settings();

        public static string ClientLocale { get { return ClientSettings.Locale; } set { ClientSettings.Locale = value; ClientSettings.Save(); } }

        public static Dictionary<string, string> LocaleStrings { get; } = new Dictionary<string, string>();
        public static Dictionary<string, string> LocalesIds { get; } = new Dictionary<string, string>();
        
        public static void LoadLocales()
        {
            Program.Log(Utils.LogEntryType.Info, "Loading locales metadata...");
            string[] files = Directory.EnumerateFiles(Path.Combine(Environment.CurrentDirectory, "resources\\locales\\")).ToArray();
            foreach (var file in files)
            {
                Program.Log(Utils.LogEntryType.Debug, "Loading locale metadata of " + file);
                OnDemandPackage localePakMeta = new OnDemandPackage(file);
                string[] lines = localePakMeta.ReadLines("metadata.lmd");
                string id = "";
                string name = "";
                foreach (var lineRoot in lines)
                {
                    string line = Encoding.UTF8.GetString(Encoding.Default.GetBytes(lineRoot));
                    string[] ln_split = line.Split('=');
                    
                    switch (ln_split[0].ToLower())
                    {
                        case "localename":
                            name = ln_split[1];
                            break;
                        case "localeid":
                            id = ln_split[1];
                            break;
                    }
                }
                LocalesIds.Add(name, id);
            }

            Program.Log(Utils.LogEntryType.Info, "Loading locale files (" + ClientLocale + ")...");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            OnDemandPackage localePak = new OnDemandPackage(Path.Combine(Environment.CurrentDirectory, "resources\\locales\\" + ClientLocale + ".cmpkg"));
            
            AddLocales(localePak, "form.main.strings");
            AddLocales(localePak, "form.connectTo.strings");
            AddLocales(localePak, "form.authorize.strings");
            AddLocales(localePak, "common.strings");
            AddLocales(localePak, "form.logs.strings");

            stopwatch.Stop();
            Program.Log(Utils.LogEntryType.Info, "Locale files loaded! Elapsed " + stopwatch.Elapsed.ToString());
        }

        public static void SaveSettings()
        {
            ClientSettings.Save();
        }

        private static void AddLocales(OnDemandPackage localePak, string file)
        {
            string[] locales = localePak.ReadLines(file);
            foreach (var rootPair in locales)
            {
                string pair = Encoding.UTF8.GetString(Encoding.Default.GetBytes(rootPair));
                if (pair != string.Empty && pair != null && pair != "")
                {
                    string[] kvpair = pair.Split('=');
                    LocaleStrings.Add(kvpair[0], kvpair[1]);
                }
                Program.Log(Utils.LogEntryType.Debug, "Adding locale key from \"" + file + "\" " + pair);
            }
        }
    }
}
