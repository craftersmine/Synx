using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace craftersmine.Synx.Client.Utils
{
    public sealed class Logger
    {
        private string _loadTime;
        private string _file;
        public List<LogEntry> LogEntries { get; } = new List<LogEntry>();

        public Logger(string name)
        {
            string directory = Path.Combine(StaticData.ClientRoot, "logs");
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
            if (DateTime.Now.Hour.ToString().Length < 2)
                _loadTime = DateTime.Now.ToShortDateString() + "_0" + DateTime.Now.ToShortTimeString();
            else _loadTime = DateTime.Now.ToShortDateString() + "_" + DateTime.Now.ToShortTimeString();
            _file = Path.Combine(directory, name + "_" + _loadTime.Replace(':', '-') + ".log");
            File.WriteAllText(_file, "");
        }

        public void Log(LogEntryType prefix, string contents, bool isOnlyConsole = false)
        {
            string _date;
            if (DateTime.Now.Hour.ToString().Length < 2)
                _date = DateTime.Now.ToShortDateString() + " 0" + DateTime.Now.ToShortTimeString();
            else _date = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            string logLineCtor = _date + " [" + prefix.ToString().ToUpper() + "]" + " " + contents + "\r\n";
#if DEBUG
            if (!isOnlyConsole)
                File.AppendAllText(_file, logLineCtor);
            Console.Write(logLineCtor);
            LogEntry entry = new LogEntry { Contents = contents, EntryDateTime = _date, Type = prefix };
            LogEntries.Add(entry);
#else
            if (prefix != LogEntryType.Debug)
            {
                if (!isOnlyConsole)
                    File.AppendAllText(_file, logLineCtor);
                Console.Write(logLineCtor);
                LogEntry entry = new LogEntry { Contents = contents, EntryDateTime = _date, Type = prefix };
                LogEntries.Add(entry);
            }
#endif

        }

        public void LogException(LogEntryType prefix, Exception exception)
        {
            string[] stacktrace = exception.StackTrace.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            Log(prefix, "An exception has occurred!");
            Log(prefix, "Exception message: " + exception.Message);
            Log(prefix, "Exception type: " + exception.GetType().ToString());
            Log(prefix, "==== START OF STACKTRACE ====");
            foreach (var stln in stacktrace)
            {
                Log(prefix, stln);
            }
            Log(prefix, "====  END OF STACKTRACE  ====");
        }
    }

    public struct LogEntry
    {
        public LogEntryType Type { get; set; }
        public string Contents { get; set; }
        public string EntryDateTime { get; set; }
    }

    public enum LogEntryType { Error = 1, Info = 0, Warning = 2, Critical = 5, Connection = 7, Success = 6, Done = 3, Debug = 10, Stacktrace = 4, Unknown = 9, Crash = 8 }
}
