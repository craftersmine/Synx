using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;

namespace craftersmine.Synx.Client
{
    public sealed class StaticData
    {
        public static WebSocket ClientInstance { get; set; }
        public static Utils.Logger LoggerInstance { get; set; }

        public static string ClientRoot { get; set; }
    }
}
