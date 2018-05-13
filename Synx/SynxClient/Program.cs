using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using craftersmine.Synx.Client.Core;

namespace craftersmine.Synx.Client
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                ClientEnvironment.InitiateClientInstances(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Synx"));
                Log("info", "Initializing client...");
                App.StaticData.LoadLocales();
                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                StaticData.LoggerInstance.LogException("error", ex);
                MessageBox.Show("An exception has occured!\r\n\r\nApplication has crashed! Message: " + ex.Message + "\r\n\r\nStack Trace:\r\n" + ex.StackTrace, "Synx - Application crash!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        public static void Log(string prefix, string content)
        {
            StaticData.LoggerInstance.Log(prefix, content);
        }

        public static void LogException(string prefix, Exception ex)
        {
            StaticData.LoggerInstance.LogException(prefix, ex);
        }
    }
}
