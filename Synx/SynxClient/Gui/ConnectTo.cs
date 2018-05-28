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
    public partial class ConnectTo : Form
    {
        public ConnectTo()
        {
            InitializeComponent();
            ApplyLocales(App.StaticData.ClientLocale);
            address.Text = App.StaticData.ClientSettings.LastServerAddress;
            port.Value = App.StaticData.ClientSettings.LastServerPort;
            autoconnectToLast.Checked = App.StaticData.ClientSettings.AutoconnectToLast;
        }

        public void ApplyLocales(string localeId)
        {
            Program.Log(Utils.LogEntryType.Info, "Applying locales for \"connectTo\" Form...");
            this.Text = this.Text.Replace("{connect.title}", App.StaticData.LocaleStrings["connect.title"]);
            labelAddress.Text = App.StaticData.LocaleStrings["connect.label.address"];
            labelPort.Text = App.StaticData.LocaleStrings["connect.label.port"];
            labelTip.Text = App.StaticData.LocaleStrings["connect.label.tip"];
            autoconnectToLast.Text = App.StaticData.LocaleStrings["connect.checkbox.autoconnectToLast"];
            connect.Text = App.StaticData.LocaleStrings["connect.button.connectTo"];
            cancel.Text = App.StaticData.LocaleStrings["common.button.cancel"];
            Program.Log(Utils.LogEntryType.Done, "Applying locales for \"connectTo\" Form... Done");
        }

        private void connect_Click(object sender, EventArgs e)
        {
            App.StaticData.ClientSettings.LastServerAddress = address.Text;
            App.StaticData.ClientSettings.LastServerPort = (int)port.Value;
            App.StaticData.ClientSettings.AutoconnectToLast = autoconnectToLast.Checked;
            App.StaticData.SaveSettings();
            ClientController.CreateClientInstance("ws://" + App.StaticData.ClientSettings.LastServerAddress, App.StaticData.ClientSettings.LastServerPort);
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
