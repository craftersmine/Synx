namespace craftersmine.Synx.Client.Gui
{
    partial class ConnectTo
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
            this.labelTip = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.autoconnectToLast = new System.Windows.Forms.CheckBox();
            this.connect = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.port = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.port)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTip
            // 
            this.labelTip.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTip.Location = new System.Drawing.Point(12, 9);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(365, 29);
            this.labelTip.TabIndex = 0;
            this.labelTip.Text = "{connect.label.tip}";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(12, 38);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(125, 13);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "{connect.label.address}";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(15, 54);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(234, 22);
            this.address.TabIndex = 2;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(270, 38);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(107, 13);
            this.labelPort.TabIndex = 3;
            this.labelPort.Text = "{connect.label.port}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = ":";
            // 
            // autoconnectToLast
            // 
            this.autoconnectToLast.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.autoconnectToLast.Location = new System.Drawing.Point(15, 82);
            this.autoconnectToLast.Name = "autoconnectToLast";
            this.autoconnectToLast.Size = new System.Drawing.Size(360, 37);
            this.autoconnectToLast.TabIndex = 6;
            this.autoconnectToLast.Text = "{connect.checkbox.autoconnectToLast}";
            this.autoconnectToLast.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.autoconnectToLast.UseVisualStyleBackColor = true;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(258, 125);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(119, 23);
            this.connect.TabIndex = 7;
            this.connect.Text = "{connect.button.connectTo}";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(177, 125);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "{common.button.cancel}";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(271, 55);
            this.port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(106, 22);
            this.port.TabIndex = 9;
            // 
            // ConnectTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 160);
            this.Controls.Add(this.port);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.autoconnectToLast);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.address);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelTip);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectTo";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Synx - {connect.title}";
            ((System.ComponentModel.ISupportInitialize)(this.port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox autoconnectToLast;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.NumericUpDown port;
    }
}