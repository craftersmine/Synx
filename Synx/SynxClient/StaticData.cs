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
        private static Settings settings = new Settings();
        private static Dictionary<string, string> localeStrings = new Dictionary<string, string>();

        internal static Settings ClientSettings => settings;
        public static string ClientLocale { get { return ClientSettings.Locale; } set { ClientSettings.Locale = value; ClientSettings.Save(); } }

        public static Dictionary<string, string> LocaleStrings => localeStrings;

        public static void LoadLocales()
        {
            Program.Log("info", "Loading locale files (" + ClientLocale + ")...");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            OnDemandPackage localePak = new OnDemandPackage(Path.Combine(Environment.CurrentDirectory, "resources\\locales\\" + ClientLocale + ".pak"));
            string[] mainFormLocales = localePak.ReadLines("form.main.strings");
            foreach (var pair in mainFormLocales)
            {
                if (pair != string.Empty && pair != null && pair != "")
                {
                    string[] kvpair = pair.Split('=');
                    LocaleStrings.Add(kvpair[0], kvpair[1]);
                }
            }

            stopwatch.Stop();
            Program.Log("info", "Locale files loaded! Elapsed " + stopwatch.Elapsed.ToString());
        }
    }
}
