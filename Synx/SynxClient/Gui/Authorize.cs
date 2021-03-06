﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace craftersmine.Synx.Client.Gui
{
    public partial class Authorize : Form
    {
        public Authorize()
        {
            InitializeComponent();
            ApplyLocales(App.StaticData.ClientLocale);
        }

        public void ApplyLocales(string localeId)
        {
            Program.Log(Utils.LogEntryType.Info, "Applying locales for \"authorize\" Form...");
            this.Text = this.Text.Replace("{authorize.title}", App.StaticData.LocaleStrings["authorize.title"]);
            loginLabel.Text = App.StaticData.LocaleStrings["authorize.label.login"];
            passwordLabel.Text = App.StaticData.LocaleStrings["authorize.label.password"];
            tip.Text = App.StaticData.LocaleStrings["authorize.label.tip"];
            buttonAuthorize.Text = App.StaticData.LocaleStrings["authorize.button.authorize"];
            cancel.Text = App.StaticData.LocaleStrings["common.button.cancel"];
            Program.Log(Utils.LogEntryType.Done, "Applying locales for \"authorize\" Form... Done");
        }

        private void buttonAuthorize_Click(object sender, EventArgs e)
        {
            string encryptedPass = Utils.MD5Compute.ComputeMD5(Utils.MD5Compute.ComputeMD5(password.Text));
            App.StaticData.ClientSettings.Password = encryptedPass;
            App.StaticData.ClientSettings.Username = login.Text;
            App.StaticData.ClientSettings.Save();
            
        }
    }
}
