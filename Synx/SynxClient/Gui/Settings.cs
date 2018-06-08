using System;
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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            LoadSettings();
            //ApplyLocales(App.StaticData.ClientLocale);
        }

        public void ApplyLocales(string localeId)
        {
            Program.Log(Utils.LogEntryType.Info, "Applying locales for \"settings\" Form...");
            this.Text = this.Text.Replace("{settings.title}", App.StaticData.LocaleStrings["settings.title"]);
            labelLang.Text = App.StaticData.LocaleStrings["settings.label.language"];
            autoconnectToLast.Text = App.StaticData.LocaleStrings["settings.checkbox.autoconnectToLast"];
            buttonEditCredentials.Text = App.StaticData.LocaleStrings["settings.button.editCredentials"];
            buttonResetCredentials.Text = App.StaticData.LocaleStrings["settings.button.resetCredentials"];
            buttonApply.Text = App.StaticData.LocaleStrings["common.button.apply"];
            buttonOk.Text = App.StaticData.LocaleStrings["common.button.ok"];
            buttonCancel.Text = App.StaticData.LocaleStrings["common.button.cancel"];
            Program.Log(Utils.LogEntryType.Done, "Applying locales for \"authorize\" Form... Done");
        }

        public void LoadSettings()
        {
            autoconnectToLast.Checked = App.StaticData.ClientSettings.AutoconnectToLast;
            foreach (var lng in App.StaticData.LocalesIds)
            {
                comboBox1.Items.Add(lng.Key);
            }
            foreach (var lng in App.StaticData.LocalesIds)
            {
                if (lng.Value == App.StaticData.ClientLocale)
                {
                    comboBox1.SelectedItem = lng.Value;
                    break;
                }
                else continue;
            }
        }

        public void SaveSettings()
        {
            foreach (var lng in App.StaticData.LocalesIds)
            {
                if (comboBox1.SelectedItem.ToString() == lng.Key)
                {
                    App.StaticData.ClientLocale = lng.Value;
                    break;
                }
                else continue;
            }
            App.StaticData.ClientSettings.AutoconnectToLast = autoconnectToLast.Checked;
            App.StaticData.ClientSettings.Save();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            SaveSettings();
            this.Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
