using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Synx.Client.Utils;

namespace craftersmine.Synx.Client.Core
{
    public sealed class ClientEnvironment
    {
        private static Dictionary<string, string> predefinedConfig = new Dictionary<string, string>();

        public static void InitiateClientInstances(string clientRoot)
        {
            StaticData.ClientRoot = clientRoot;
            StaticData.LoggerInstance = new Logger("synx-client");
        }
    }
}
