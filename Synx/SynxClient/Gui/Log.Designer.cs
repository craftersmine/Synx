namespace craftersmine.Synx.Client.Gui
{
    partial class Log
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
            this.components = new System.ComponentModel.Container();
            this.sendLogs = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.iconCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tagCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contentsCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // sendLogs
            // 
            this.sendLogs.Location = new System.Drawing.Point(12, 498);
            this.sendLogs.Name = "sendLogs";
            this.sendLogs.Size = new System.Drawing.Size(161, 23);
            this.sendLogs.TabIndex = 0;
            this.sendLogs.Text = "{logs.button.sendLogs}";
            this.sendLogs.UseVisualStyleBackColor = true;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(495, 498);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(152, 23);
            this.close.TabIndex = 1;
            this.close.Text = "{common.button.close}";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.iconCol,
            this.dateCol,
            this.tagCol,
            this.contentsCol});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(635, 480);
            this.listView1.SmallImageList = this.imageList;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // iconCol
            // 
            this.iconCol.Text = "";
            this.iconCol.Width = 25;
            // 
            // dateCol
            // 
            this.dateCol.Text = "{logs.column.contents}";
            this.dateCol.Width = 87;
            // 
            // tagCol
            // 
            this.tagCol.Text = "{logs.column.tag}";
            this.tagCol.Width = 99;
            // 
            // contentsCol
            // 
            this.contentsCol.Text = "{logs.column.contents}";
            this.contentsCol.Width = 401;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 533);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.sendLogs);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Synx - {logs.title}";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sendLogs;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader iconCol;
        private System.Windows.Forms.ColumnHeader tagCol;
        private System.Windows.Forms.ColumnHeader contentsCol;
        private System.Windows.Forms.ColumnHeader dateCol;
        private System.Windows.Forms.ImageList imageList;
    }
}