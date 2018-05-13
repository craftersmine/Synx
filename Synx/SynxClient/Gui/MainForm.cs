using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace craftersmine.Synx.Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ApplyLocales(App.StaticData.ClientLocale);
            statusBar.Text = "{main.status.ready}";
        }

        private void ApplyLocales(string localeId)
        {
            Program.Log("info", "Applying locales...");
            this.Text = Text.Replace("{main.title}", App.StaticData.LocaleStrings["main.title"]);

            mainTabDevicesList.Text = App.StaticData.LocaleStrings["main.tab.devicesList"];
            mainTabHome.Text = App.StaticData.LocaleStrings["main.tab.home"];
            mainTabSyncingObjectsList.Text = App.StaticData.LocaleStrings["main.tab.syncingObjectsList"];

            deviceModelColumnHeaderDevList.Text = App.StaticData.LocaleStrings["main.list.devicesList.column.model"];
            deviceTypeColumnHeaderDevList.Text = App.StaticData.LocaleStrings["main.list.devicesList.column.deviceType"];
            deviceUserColumnHeaderDevList.Text = App.StaticData.LocaleStrings["main.list.devicesList.column.user"];

            syncStatusColumnHeaderSyncingObjectsList.Text = App.StaticData.LocaleStrings["main.list.syncingObjects.column.syncStatus"];
            folderNameColumnHeaderSyncingObjectsList.Text = App.StaticData.LocaleStrings["main.list.syncingObjects.column.folderName"];
            folderPathColumnHeaderSyncingObjectsList.Text = App.StaticData.LocaleStrings["main.list.syncingObjects.column.folderPath"];

            linkConnectToServer.Text = App.StaticData.LocaleStrings["main.links.connectToServer"];
            linkCreateServer.Text = App.StaticData.LocaleStrings["main.links.createServer"];

            welcomeLabel.Text = App.StaticData.LocaleStrings["main.label.welcome"];

            mainMenuConnectToServer.Text = App.StaticData.LocaleStrings["main.menu.Synx.connectToServer"];
            mainMenuDisconnect.Text = App.StaticData.LocaleStrings["main.menu.Synx.disconnectFromServer"];
            mainMenuExit.Text = App.StaticData.LocaleStrings["main.menu.Synx.exit"];
            
            mainMenuHeaderHelp.Text = App.StaticData.LocaleStrings["main.menu.header.help"];
            mainMenuHeaderService.Text = App.StaticData.LocaleStrings["main.menu.header.service"];
            mainMenuHeaderSync.Text = App.StaticData.LocaleStrings["main.menu.header.sync"];
            mainMenuHeaderUser.Text = App.StaticData.LocaleStrings["main.menu.header.user"];

            mainMenuHelpAbout.Text = App.StaticData.LocaleStrings["main.menu.help.about"];

            mainMenuServiceSettings.Text = App.StaticData.LocaleStrings["main.menu.service.settings"];

            mainMenuSyncPause.Text = App.StaticData.LocaleStrings["main.menu.sync.pauseSyncFor"];
            mainMenuSyncStart.Text = App.StaticData.LocaleStrings["main.menu.sync.startSync"];
            mainMenuSyncStop.Text = App.StaticData.LocaleStrings["main.menu.sync.stopSync"];
            
            mainMenuUserClearAllData.Text = App.StaticData.LocaleStrings["main.menu.user.clearAllSyncedData"];
            mainMenuUserRestoreSynced.Text = App.StaticData.LocaleStrings["main.menu.user.restoreSyncedDataFrom"];
            mainMenuUserInfo.Text = App.StaticData.LocaleStrings["main.menu.user.info"];
            Program.Log("info", "Locales applied!");
        }
    }
}
