using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using craftersmine.Synx.Client.Core;

namespace craftersmine.Synx.Client.Gui
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ApplyLocales(App.StaticData.ClientLocale);
            statusProgress.Visible = false;
            statusBar.Text = App.StaticData.LocaleStrings["main.status.ready"];

            ClientController.OnCreatingClientInstance += OnCreatingClientInstance;
            ClientController.OnCreatedClientInstance += OnCreatedClientInstance;
            ClientController.OnConnecting += ClientOnConnecting;
            ClientController.OnClose += ClientOnClose;
            ClientController.OnError += ClientOnError;
            ClientController.OnMessage += ClientOnMessage;
            ClientController.OnOpen += ClienOnOpen;
        }

        private void ClientOnConnecting(object sender, ConnectingToServerEventArgs e)
        {
            statusProgress.Visible = true;
            statusProgress.Style = ProgressBarStyle.Marquee;
            statusBar.Text = App.StaticData.LocaleStrings["main.status.connecting"].Replace("{address}", e.Address).Replace("{port}", e.Port.ToString());
            statusProgress.Value = 0;
        }

        private void ClienOnOpen(object sender, EventArgs e)
        {
            statusProgress.Visible = true;
            statusProgress.Style = ProgressBarStyle.Marquee;
            mainTabHomePanel.Enabled = false;
            mainMenuConnectToServer.Enabled = false;
            statusProgress.Visible = false;
            statusBar.Text = App.StaticData.LocaleStrings["main.status.connected"].Replace("{address}", App.StaticData.ClientSettings.LastServerAddress).Replace("{port}", App.StaticData.ClientSettings.LastServerPort.ToString());
        }

        private void ClientOnMessage(object sender, WebSocketSharp.MessageEventArgs e)
        {
            //statusBar.Text = e.Data;
            Program.LogOnlyConsole("info/debug", "Message received: " + e.Data);
        }

        private void ClientOnError(object sender, WebSocketSharp.ErrorEventArgs e)
        {
            //statusBar.Text = e.Message;
            Program.LogException("error", e.Exception);
        }

        private void ClientOnClose(object sender, WebSocketSharp.CloseEventArgs e)
        {
            
            Invoke(new Action(() =>
            {
                statusProgress.Visible = false;
                if (e.WasClean)
                    statusBar.Text = App.StaticData.LocaleStrings["main.status.disconnectedClearly"].Replace("{address}", App.StaticData.ClientSettings.LastServerAddress).Replace("{port}", App.StaticData.ClientSettings.LastServerPort.ToString());
                else
                {
                    statusBar.Text = App.StaticData.LocaleStrings["main.status.disconnectedWithError"].Replace("{address}", App.StaticData.ClientSettings.LastServerAddress).Replace("{port}", App.StaticData.ClientSettings.LastServerPort.ToString()).Replace("{reason}", e.Reason);
                    MessageBox.Show(App.StaticData.LocaleStrings["main.status.disconnectedWithError"].Replace("{address}", App.StaticData.ClientSettings.LastServerAddress).Replace("{port}", App.StaticData.ClientSettings.LastServerPort.ToString()).Replace("{reason}", e.Reason), App.StaticData.LocaleStrings["common.message.title.error"], MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                mainTabHomePanel.Enabled = true;
                mainMenuConnectToServer.Enabled = true;
                mainMenuDisconnect.Enabled = false;
            }));
        }

        private void OnCreatedClientInstance(object sender, CreationEventDelegate e)
        {
            statusProgress.Visible = true;
            statusProgress.Style = ProgressBarStyle.Continuous;
            statusProgress.Value = 100;
            if (e.IsSuccessful)
            {
                mainMenuDisconnect.Enabled = true;
                ClientController.InitializeConnection();
            }
        }

        private void OnCreatingClientInstance(object sender, EventArgs e)
        {
            statusProgress.Visible = true;
            statusProgress.Style = ProgressBarStyle.Marquee;
            mainTabHomePanel.Enabled = false;
            mainMenuConnectToServer.Enabled = false;
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
            mainMenuServiceLog.Text = App.StaticData.LocaleStrings["main.menu.service.log"];

            mainMenuSyncPause.Text = App.StaticData.LocaleStrings["main.menu.sync.pauseSyncFor"];
            mainMenuSyncStart.Text = App.StaticData.LocaleStrings["main.menu.sync.startSync"];
            mainMenuSyncStop.Text = App.StaticData.LocaleStrings["main.menu.sync.stopSync"];
            
            mainMenuUserClearAllData.Text = App.StaticData.LocaleStrings["main.menu.user.clearAllSyncedData"];
            mainMenuUserRestoreSynced.Text = App.StaticData.LocaleStrings["main.menu.user.restoreSyncedDataFrom"];
            mainMenuUserInfo.Text = App.StaticData.LocaleStrings["main.menu.user.info"];
            Program.Log("info", "Locales applied!");
        }

        private void mainMenuConnectToServer_Click(object sender, EventArgs e) => new ConnectTo().ShowDialog();

        private void mainMenuDisconnect_Click(object sender, EventArgs e)
        {
            ClientController.CloseConnection();
        }

        private void linkConnectToServer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => new ConnectTo().ShowDialog();
    }
}
