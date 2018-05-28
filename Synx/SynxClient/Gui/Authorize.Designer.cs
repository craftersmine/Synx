namespace craftersmine.Synx.Client.Gui
{
    partial class Authorize
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
            this.tip = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.buttonAuthorize = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tip
            // 
            this.tip.Location = new System.Drawing.Point(12, 9);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(316, 28);
            this.tip.TabIndex = 0;
            this.tip.Text = "{authorize.label.tip}";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(12, 63);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(120, 13);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "{authorize.label.login}";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(12, 79);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(316, 22);
            this.login.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(12, 129);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(316, 22);
            this.password.TabIndex = 4;
            this.password.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(12, 113);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(143, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "{authorize.label.password}";
            // 
            // buttonAuthorize
            // 
            this.buttonAuthorize.Location = new System.Drawing.Point(174, 260);
            this.buttonAuthorize.Name = "buttonAuthorize";
            this.buttonAuthorize.Size = new System.Drawing.Size(154, 23);
            this.buttonAuthorize.TabIndex = 5;
            this.buttonAuthorize.Text = "{authorize.button.authorize}";
            this.buttonAuthorize.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(85, 260);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(83, 23);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "{common.button.cancel}";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // Authorize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 295);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.buttonAuthorize);
            this.Controls.Add(this.password);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.login);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.tip);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Authorize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Synx - {authorize.title}";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button buttonAuthorize;
        private System.Windows.Forms.Button cancel;
    }
}