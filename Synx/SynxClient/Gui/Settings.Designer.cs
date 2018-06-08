namespace craftersmine.Synx.Client.Gui
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.buttonEditCredentials = new System.Windows.Forms.Button();
            this.buttonResetCredentials = new System.Windows.Forms.Button();
            this.autoconnectToLast = new System.Windows.Forms.CheckBox();
            this.groupBoxApp = new System.Windows.Forms.GroupBox();
            this.labelLang = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBoxUser.SuspendLayout();
            this.groupBoxApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.buttonEditCredentials);
            this.groupBoxUser.Controls.Add(this.buttonResetCredentials);
            this.groupBoxUser.Controls.Add(this.autoconnectToLast);
            this.groupBoxUser.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(374, 92);
            this.groupBoxUser.TabIndex = 0;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "{settings.group.user}";
            // 
            // buttonEditCredentials
            // 
            this.buttonEditCredentials.Location = new System.Drawing.Point(6, 62);
            this.buttonEditCredentials.Name = "buttonEditCredentials";
            this.buttonEditCredentials.Size = new System.Drawing.Size(196, 23);
            this.buttonEditCredentials.TabIndex = 9;
            this.buttonEditCredentials.Text = "{settings.button.editCredentials}";
            this.buttonEditCredentials.UseVisualStyleBackColor = true;
            // 
            // buttonResetCredentials
            // 
            this.buttonResetCredentials.Location = new System.Drawing.Point(208, 62);
            this.buttonResetCredentials.Name = "buttonResetCredentials";
            this.buttonResetCredentials.Size = new System.Drawing.Size(160, 23);
            this.buttonResetCredentials.TabIndex = 8;
            this.buttonResetCredentials.Text = "{settings.button.resetCredentials}";
            this.buttonResetCredentials.UseVisualStyleBackColor = true;
            // 
            // autoconnectToLast
            // 
            this.autoconnectToLast.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.autoconnectToLast.Location = new System.Drawing.Point(6, 19);
            this.autoconnectToLast.Name = "autoconnectToLast";
            this.autoconnectToLast.Size = new System.Drawing.Size(362, 37);
            this.autoconnectToLast.TabIndex = 7;
            this.autoconnectToLast.Text = "{settings.checkbox.autoconnectToLast}";
            this.autoconnectToLast.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.autoconnectToLast.UseVisualStyleBackColor = true;
            // 
            // groupBoxApp
            // 
            this.groupBoxApp.Controls.Add(this.labelLang);
            this.groupBoxApp.Controls.Add(this.comboBox1);
            this.groupBoxApp.Location = new System.Drawing.Point(12, 110);
            this.groupBoxApp.Name = "groupBoxApp";
            this.groupBoxApp.Size = new System.Drawing.Size(374, 62);
            this.groupBoxApp.TabIndex = 1;
            this.groupBoxApp.TabStop = false;
            this.groupBoxApp.Text = "{settings.group.application}";
            // 
            // labelLang
            // 
            this.labelLang.AutoSize = true;
            this.labelLang.Location = new System.Drawing.Point(3, 18);
            this.labelLang.Name = "labelLang";
            this.labelLang.Size = new System.Drawing.Size(134, 13);
            this.labelLang.TabIndex = 1;
            this.labelLang.Text = "{settings.label.language}";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(362, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(284, 377);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(102, 23);
            this.buttonApply.TabIndex = 2;
            this.buttonApply.Text = "{common.button.apply}";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(183, 377);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(95, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "{common.button.cancel}";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(77, 377);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(100, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "{common.button.ok}";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // Settings
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(398, 412);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.groupBoxApp);
            this.Controls.Add(this.groupBoxUser);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Synx - {settings.title}";
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxApp.ResumeLayout(false);
            this.groupBoxApp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.Button buttonEditCredentials;
        private System.Windows.Forms.Button buttonResetCredentials;
        private System.Windows.Forms.CheckBox autoconnectToLast;
        private System.Windows.Forms.GroupBox groupBoxApp;
        private System.Windows.Forms.Label labelLang;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
    }
}