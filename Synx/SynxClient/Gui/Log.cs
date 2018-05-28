using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using craftersmine.Packager.Lib.Core;

namespace craftersmine.Synx.Client.Gui
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
            ApplyLocales(App.StaticData.ClientLocale);
            LoadIcons();
            PopulateList();
        }

        private void LoadIcons()
        {
            OnDemandPackage package = new OnDemandPackage(Path.Combine(Environment.CurrentDirectory, "resources\\icons\\logs.pak"));

            // Sequence of lines must be observed!!!
            imageList.Images.Add(Utils.ImageFromBytesConverter.ByteArrayToImage(package.ReadBytes("info.png")));
            imageList.Images.Add(Utils.ImageFromBytesConverter.ByteArrayToImage(package.ReadBytes("error.png")));
            imageList.Images.Add(Utils.ImageFromBytesConverter.ByteArrayToImage(package.ReadBytes("warning.png")));
            imageList.Images.Add(Utils.ImageFromBytesConverter.ByteArrayToImage(package.ReadBytes("done.png")));
            imageList.Images.Add(Utils.ImageFromBytesConverter.ByteArrayToImage(package.ReadBytes("stacktrace.png")));
            imageList.Images.Add(Utils.ImageFromBytesConverter.ByteArrayToImage(package.ReadBytes("critical.png")));
            imageList.Images.Add(Utils.ImageFromBytesConverter.ByteArrayToImage(package.ReadBytes("success.png")));
            imageList.Images.Add(Utils.ImageFromBytesConverter.ByteArrayToImage(package.ReadBytes("connection.png")));
            imageList.Images.Add(Utils.ImageFromBytesConverter.ByteArrayToImage(package.ReadBytes("crash.png")));
            imageList.Images.Add(Utils.ImageFromBytesConverter.ByteArrayToImage(package.ReadBytes("unknown.png")));
            imageList.Images.Add(Utils.ImageFromBytesConverter.ByteArrayToImage(package.ReadBytes("debug.png")));
        }

        private void PopulateList()
        {
            foreach (var entry in StaticData.LoggerInstance.LogEntries)
            {
                int imageId = (int)Utils.LogEntryType.Unknown;
                string entryType = App.StaticData.LocaleStrings["logs.entryType.unknown"];
                switch (entry.Type)
                {
                    case Utils.LogEntryType.Info:
                        entryType = App.StaticData.LocaleStrings["logs.entryType.info"];
                        break;
                    case Utils.LogEntryType.Error:
                        entryType = App.StaticData.LocaleStrings["logs.entryType.error"];
                        break;
                    case Utils.LogEntryType.Warning:
                        entryType = App.StaticData.LocaleStrings["logs.entryType.warning"];
                        break;
                    case Utils.LogEntryType.Done:
                        entryType = App.StaticData.LocaleStrings["logs.entryType.done"];
                        break;
                    case Utils.LogEntryType.Critical:
                        entryType = App.StaticData.LocaleStrings["logs.entryType.critical"];
                        break;
                    case Utils.LogEntryType.Connection:
                        entryType = App.StaticData.LocaleStrings["logs.entryType.connection"];
                        break;
                    case Utils.LogEntryType.Crash:
                        entryType = App.StaticData.LocaleStrings["logs.entryType.crash"];
                        break;
                    case Utils.LogEntryType.Debug:
                        entryType = App.StaticData.LocaleStrings["logs.entryType.debug"];
                        break;
                    case Utils.LogEntryType.Stacktrace:
                        entryType = App.StaticData.LocaleStrings["logs.entryType.stacktrace"];
                        break;
                    case Utils.LogEntryType.Success:
                        entryType = App.StaticData.LocaleStrings["logs.entryType.success"];
                        break;

                    default:
                    case Utils.LogEntryType.Unknown:
                        entryType = App.StaticData.LocaleStrings["logs.entryType.unknown"];
                        break;
                }
                listView1.Items.Add(new ListViewItem(new string[] { null, entry.EntryDateTime, entryType, entry.Contents }, imageId));
            }
        }

        public void ApplyLocales(string localeId)
        {
            Program.Log(Utils.LogEntryType.Info, "Applying locales for \"logs\" Form...");
            this.Text = this.Text.Replace("{logs.title}", App.StaticData.LocaleStrings["logs.title"]);
            tagCol.Text = App.StaticData.LocaleStrings["logs.column.tag"];
            contentsCol.Text = App.StaticData.LocaleStrings["logs.column.contents"];
            sendLogs.Text = App.StaticData.LocaleStrings["logs.button.sendLogs"];
            close.Text = App.StaticData.LocaleStrings["common.button.close"];
            dateCol.Text = App.StaticData.LocaleStrings["logs.column.date"];
            Program.Log(Utils.LogEntryType.Done, "Applying locales for \"logs\" Form... Done");
        }
    }
}
