namespace craftersmine.Synx.Client.Gui
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.synxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuConnectToServer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mainMenuDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuHeaderUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mainMenuUserClearAllData = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuUserRestoreSynced = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuHeaderSync = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuSyncStart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mainMenuSyncStop = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuSyncPause = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuHeaderService = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuServiceSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuServiceLog = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuHeaderHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tabController = new System.Windows.Forms.TabControl();
            this.mainTabHome = new System.Windows.Forms.TabPage();
            this.mainTabHomePanel = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoLabel = new System.Windows.Forms.Label();
            this.linkCreateServer = new System.Windows.Forms.LinkLabel();
            this.linkConnectToServer = new System.Windows.Forms.LinkLabel();
            this.mainTabSyncingObjectsList = new System.Windows.Forms.TabPage();
            this.mainTabSyncingObjects = new System.Windows.Forms.Panel();
            this.syncingObjectsList = new System.Windows.Forms.ListView();
            this.iconColumnHeaderSyncingObjectsList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderNameColumnHeaderSyncingObjectsList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderPathColumnHeaderSyncingObjectsList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.syncStatusColumnHeaderSyncingObjectsList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.syncingAdd = new System.Windows.Forms.ToolStripButton();
            this.syncingRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.syncingStartSync = new System.Windows.Forms.ToolStripButton();
            this.syncingStopSync = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.syncingClearList = new System.Windows.Forms.ToolStripButton();
            this.mainTabDevicesList = new System.Windows.Forms.TabPage();
            this.mainTabDevicesListPanel = new System.Windows.Forms.Panel();
            this.devicesList = new System.Windows.Forms.ListView();
            this.iconColumnHeaderDevList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deviceModelColumnHeaderDevList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deviceUserColumnHeaderDevList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deviceTypeColumnHeaderDevList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.devListRestoreData = new System.Windows.Forms.ToolStripButton();
            this.devListShowSynced = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.devListWipeSyncedData = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabController.SuspendLayout();
            this.mainTabHome.SuspendLayout();
            this.mainTabHomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainTabSyncingObjectsList.SuspendLayout();
            this.mainTabSyncingObjects.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.mainTabDevicesList.SuspendLayout();
            this.mainTabDevicesListPanel.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.synxToolStripMenuItem,
            this.mainMenuHeaderUser,
            this.mainMenuHeaderSync,
            this.mainMenuHeaderService,
            this.mainMenuHeaderHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // synxToolStripMenuItem
            // 
            this.synxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuConnectToServer,
            this.toolStripMenuItem1,
            this.mainMenuDisconnect,
            this.mainMenuExit});
            this.synxToolStripMenuItem.Name = "synxToolStripMenuItem";
            this.synxToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.synxToolStripMenuItem.Text = "Synx";
            // 
            // mainMenuConnectToServer
            // 
            this.mainMenuConnectToServer.Name = "mainMenuConnectToServer";
            this.mainMenuConnectToServer.Size = new System.Drawing.Size(291, 22);
            this.mainMenuConnectToServer.Text = "{main.menu.Synx.connectToServer}";
            this.mainMenuConnectToServer.Click += new System.EventHandler(this.mainMenuConnectToServer_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(288, 6);
            // 
            // mainMenuDisconnect
            // 
            this.mainMenuDisconnect.Enabled = false;
            this.mainMenuDisconnect.Name = "mainMenuDisconnect";
            this.mainMenuDisconnect.Size = new System.Drawing.Size(291, 22);
            this.mainMenuDisconnect.Text = "{main.menu.Synx.disconnectFromServer}";
            this.mainMenuDisconnect.Click += new System.EventHandler(this.mainMenuDisconnect_Click);
            // 
            // mainMenuExit
            // 
            this.mainMenuExit.Name = "mainMenuExit";
            this.mainMenuExit.Size = new System.Drawing.Size(291, 22);
            this.mainMenuExit.Text = "{main.menu.Synx.exit}";
            // 
            // mainMenuHeaderUser
            // 
            this.mainMenuHeaderUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuUserInfo,
            this.toolStripMenuItem2,
            this.mainMenuUserClearAllData,
            this.mainMenuUserRestoreSynced});
            this.mainMenuHeaderUser.Enabled = false;
            this.mainMenuHeaderUser.Name = "mainMenuHeaderUser";
            this.mainMenuHeaderUser.Size = new System.Drawing.Size(152, 20);
            this.mainMenuHeaderUser.Text = "{main.menu.header.user}";
            // 
            // mainMenuUserInfo
            // 
            this.mainMenuUserInfo.Name = "mainMenuUserInfo";
            this.mainMenuUserInfo.Size = new System.Drawing.Size(297, 22);
            this.mainMenuUserInfo.Text = "{main.menu.user.info}";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(294, 6);
            // 
            // mainMenuUserClearAllData
            // 
            this.mainMenuUserClearAllData.Name = "mainMenuUserClearAllData";
            this.mainMenuUserClearAllData.Size = new System.Drawing.Size(297, 22);
            this.mainMenuUserClearAllData.Text = "{main.menu.user.clearAllSyncedData}";
            // 
            // mainMenuUserRestoreSynced
            // 
            this.mainMenuUserRestoreSynced.Name = "mainMenuUserRestoreSynced";
            this.mainMenuUserRestoreSynced.Size = new System.Drawing.Size(297, 22);
            this.mainMenuUserRestoreSynced.Text = "{main.menu.user.restoreSyncedDataFrom}";
            // 
            // mainMenuHeaderSync
            // 
            this.mainMenuHeaderSync.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuSyncStart,
            this.toolStripMenuItem3,
            this.mainMenuSyncStop,
            this.mainMenuSyncPause});
            this.mainMenuHeaderSync.Enabled = false;
            this.mainMenuHeaderSync.Name = "mainMenuHeaderSync";
            this.mainMenuHeaderSync.Size = new System.Drawing.Size(154, 20);
            this.mainMenuHeaderSync.Text = "{main.menu.header.sync}";
            // 
            // mainMenuSyncStart
            // 
            this.mainMenuSyncStart.Name = "mainMenuSyncStart";
            this.mainMenuSyncStart.Size = new System.Drawing.Size(246, 22);
            this.mainMenuSyncStart.Text = "{main.menu.sync.startSync}";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(243, 6);
            // 
            // mainMenuSyncStop
            // 
            this.mainMenuSyncStop.Name = "mainMenuSyncStop";
            this.mainMenuSyncStop.Size = new System.Drawing.Size(246, 22);
            this.mainMenuSyncStop.Text = "{main.menu.sync.stopSync}";
            // 
            // mainMenuSyncPause
            // 
            this.mainMenuSyncPause.Name = "mainMenuSyncPause";
            this.mainMenuSyncPause.Size = new System.Drawing.Size(246, 22);
            this.mainMenuSyncPause.Text = "{main.menu.sync.pauseSyncFor}";
            // 
            // mainMenuHeaderService
            // 
            this.mainMenuHeaderService.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuServiceSettings,
            this.mainMenuServiceLog});
            this.mainMenuHeaderService.Name = "mainMenuHeaderService";
            this.mainMenuHeaderService.Size = new System.Drawing.Size(166, 20);
            this.mainMenuHeaderService.Text = "{main.menu.header.service}";
            // 
            // mainMenuServiceSettings
            // 
            this.mainMenuServiceSettings.Name = "mainMenuServiceSettings";
            this.mainMenuServiceSettings.Size = new System.Drawing.Size(226, 22);
            this.mainMenuServiceSettings.Text = "{main.menu.service.settings}";
            // 
            // mainMenuServiceLog
            // 
            this.mainMenuServiceLog.Name = "mainMenuServiceLog";
            this.mainMenuServiceLog.Size = new System.Drawing.Size(226, 22);
            this.mainMenuServiceLog.Text = "{main.menu.service.log}";
            // 
            // mainMenuHeaderHelp
            // 
            this.mainMenuHeaderHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuHelpAbout});
            this.mainMenuHeaderHelp.Name = "mainMenuHeaderHelp";
            this.mainMenuHeaderHelp.Size = new System.Drawing.Size(153, 20);
            this.mainMenuHeaderHelp.Text = "{main.menu.header.help}";
            // 
            // mainMenuHelpAbout
            // 
            this.mainMenuHelpAbout.Name = "mainMenuHelpAbout";
            this.mainMenuHelpAbout.Size = new System.Drawing.Size(203, 22);
            this.mainMenuHelpAbout.Text = "{main.menu.help.about}";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar,
            this.statusProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 580);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(491, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusBar
            // 
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(374, 17);
            this.statusBar.Spring = true;
            this.statusBar.Text = "{status}";
            this.statusBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusProgress
            // 
            this.statusProgress.Name = "statusProgress";
            this.statusProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.mainTabHome);
            this.tabController.Controls.Add(this.mainTabSyncingObjectsList);
            this.tabController.Controls.Add(this.mainTabDevicesList);
            this.tabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabController.Location = new System.Drawing.Point(0, 24);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(491, 556);
            this.tabController.TabIndex = 3;
            // 
            // mainTabHome
            // 
            this.mainTabHome.Controls.Add(this.mainTabHomePanel);
            this.mainTabHome.Location = new System.Drawing.Point(4, 22);
            this.mainTabHome.Name = "mainTabHome";
            this.mainTabHome.Padding = new System.Windows.Forms.Padding(3);
            this.mainTabHome.Size = new System.Drawing.Size(483, 530);
            this.mainTabHome.TabIndex = 1;
            this.mainTabHome.Text = "{main.tab.home}";
            this.mainTabHome.UseVisualStyleBackColor = true;
            // 
            // mainTabHomePanel
            // 
            this.mainTabHomePanel.Controls.Add(this.welcomeLabel);
            this.mainTabHomePanel.Controls.Add(this.pictureBox2);
            this.mainTabHomePanel.Controls.Add(this.pictureBox1);
            this.mainTabHomePanel.Controls.Add(this.logoLabel);
            this.mainTabHomePanel.Controls.Add(this.linkCreateServer);
            this.mainTabHomePanel.Controls.Add(this.linkConnectToServer);
            this.mainTabHomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabHomePanel.Location = new System.Drawing.Point(3, 3);
            this.mainTabHomePanel.Name = "mainTabHomePanel";
            this.mainTabHomePanel.Size = new System.Drawing.Size(477, 524);
            this.mainTabHomePanel.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcomeLabel.Location = new System.Drawing.Point(24, 27);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(323, 79);
            this.welcomeLabel.TabIndex = 11;
            this.welcomeLabel.Text = "{main.label.welcome}";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(27, 200);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.logoLabel.Location = new System.Drawing.Point(234, 434);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(288, 128);
            this.logoLabel.TabIndex = 8;
            this.logoLabel.Text = "SYNX";
            // 
            // linkCreateServer
            // 
            this.linkCreateServer.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
            this.linkCreateServer.AutoSize = true;
            this.linkCreateServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkCreateServer.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkCreateServer.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkCreateServer.Location = new System.Drawing.Point(69, 209);
            this.linkCreateServer.Name = "linkCreateServer";
            this.linkCreateServer.Size = new System.Drawing.Size(130, 13);
            this.linkCreateServer.TabIndex = 7;
            this.linkCreateServer.TabStop = true;
            this.linkCreateServer.Text = "{main.links.createServer}";
            this.linkCreateServer.VisitedLinkColor = System.Drawing.Color.RoyalBlue;
            // 
            // linkConnectToServer
            // 
            this.linkConnectToServer.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
            this.linkConnectToServer.AutoSize = true;
            this.linkConnectToServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkConnectToServer.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkConnectToServer.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkConnectToServer.Location = new System.Drawing.Point(69, 153);
            this.linkConnectToServer.Name = "linkConnectToServer";
            this.linkConnectToServer.Size = new System.Drawing.Size(151, 13);
            this.linkConnectToServer.TabIndex = 6;
            this.linkConnectToServer.TabStop = true;
            this.linkConnectToServer.Text = "{main.links.connectToServer}";
            this.linkConnectToServer.VisitedLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkConnectToServer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkConnectToServer_LinkClicked);
            // 
            // mainTabSyncingObjectsList
            // 
            this.mainTabSyncingObjectsList.Controls.Add(this.mainTabSyncingObjects);
            this.mainTabSyncingObjectsList.Location = new System.Drawing.Point(4, 22);
            this.mainTabSyncingObjectsList.Name = "mainTabSyncingObjectsList";
            this.mainTabSyncingObjectsList.Padding = new System.Windows.Forms.Padding(3);
            this.mainTabSyncingObjectsList.Size = new System.Drawing.Size(483, 530);
            this.mainTabSyncingObjectsList.TabIndex = 0;
            this.mainTabSyncingObjectsList.Text = "{main.tab.syncingObjectsList}";
            this.mainTabSyncingObjectsList.UseVisualStyleBackColor = true;
            // 
            // mainTabSyncingObjects
            // 
            this.mainTabSyncingObjects.Controls.Add(this.syncingObjectsList);
            this.mainTabSyncingObjects.Controls.Add(this.toolStrip1);
            this.mainTabSyncingObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabSyncingObjects.Enabled = false;
            this.mainTabSyncingObjects.Location = new System.Drawing.Point(3, 3);
            this.mainTabSyncingObjects.Name = "mainTabSyncingObjects";
            this.mainTabSyncingObjects.Size = new System.Drawing.Size(477, 524);
            this.mainTabSyncingObjects.TabIndex = 0;
            // 
            // syncingObjectsList
            // 
            this.syncingObjectsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.iconColumnHeaderSyncingObjectsList,
            this.folderNameColumnHeaderSyncingObjectsList,
            this.folderPathColumnHeaderSyncingObjectsList,
            this.syncStatusColumnHeaderSyncingObjectsList});
            this.syncingObjectsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.syncingObjectsList.FullRowSelect = true;
            this.syncingObjectsList.GridLines = true;
            this.syncingObjectsList.LabelWrap = false;
            this.syncingObjectsList.Location = new System.Drawing.Point(0, 25);
            this.syncingObjectsList.MultiSelect = false;
            this.syncingObjectsList.Name = "syncingObjectsList";
            this.syncingObjectsList.Size = new System.Drawing.Size(477, 499);
            this.syncingObjectsList.TabIndex = 3;
            this.syncingObjectsList.UseCompatibleStateImageBehavior = false;
            this.syncingObjectsList.View = System.Windows.Forms.View.Details;
            // 
            // iconColumnHeaderSyncingObjectsList
            // 
            this.iconColumnHeaderSyncingObjectsList.Text = "";
            this.iconColumnHeaderSyncingObjectsList.Width = 22;
            // 
            // folderNameColumnHeaderSyncingObjectsList
            // 
            this.folderNameColumnHeaderSyncingObjectsList.Text = "{main.list.syncingObjects.column.folderName}";
            this.folderNameColumnHeaderSyncingObjectsList.Width = 105;
            // 
            // folderPathColumnHeaderSyncingObjectsList
            // 
            this.folderPathColumnHeaderSyncingObjectsList.Text = "{main.list.syncingObjects.column.folderPath}";
            this.folderPathColumnHeaderSyncingObjectsList.Width = 245;
            // 
            // syncStatusColumnHeaderSyncingObjectsList
            // 
            this.syncStatusColumnHeaderSyncingObjectsList.Text = "{main.list.syncingObjects.column.syncStatus}";
            this.syncStatusColumnHeaderSyncingObjectsList.Width = 80;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.syncingAdd,
            this.syncingRemove,
            this.toolStripSeparator1,
            this.syncingStartSync,
            this.syncingStopSync,
            this.toolStripSeparator2,
            this.syncingClearList});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(477, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // syncingAdd
            // 
            this.syncingAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.syncingAdd.Image = ((System.Drawing.Image)(resources.GetObject("syncingAdd.Image")));
            this.syncingAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.syncingAdd.Name = "syncingAdd";
            this.syncingAdd.Size = new System.Drawing.Size(23, 22);
            this.syncingAdd.Text = "{main.tools.syncingObjects.add}";
            // 
            // syncingRemove
            // 
            this.syncingRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.syncingRemove.Image = ((System.Drawing.Image)(resources.GetObject("syncingRemove.Image")));
            this.syncingRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.syncingRemove.Name = "syncingRemove";
            this.syncingRemove.Size = new System.Drawing.Size(23, 22);
            this.syncingRemove.Text = "{main.tools.syncingObjects.remove}";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // syncingStartSync
            // 
            this.syncingStartSync.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.syncingStartSync.Image = ((System.Drawing.Image)(resources.GetObject("syncingStartSync.Image")));
            this.syncingStartSync.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.syncingStartSync.Name = "syncingStartSync";
            this.syncingStartSync.Size = new System.Drawing.Size(23, 22);
            this.syncingStartSync.Text = "{main.tools.syncingObjects.startSync}";
            // 
            // syncingStopSync
            // 
            this.syncingStopSync.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.syncingStopSync.Image = ((System.Drawing.Image)(resources.GetObject("syncingStopSync.Image")));
            this.syncingStopSync.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.syncingStopSync.Name = "syncingStopSync";
            this.syncingStopSync.Size = new System.Drawing.Size(23, 22);
            this.syncingStopSync.Text = "{main.tools.syncingObjects.stopSync}";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // syncingClearList
            // 
            this.syncingClearList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.syncingClearList.Image = ((System.Drawing.Image)(resources.GetObject("syncingClearList.Image")));
            this.syncingClearList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.syncingClearList.Name = "syncingClearList";
            this.syncingClearList.Size = new System.Drawing.Size(23, 22);
            this.syncingClearList.Text = "{main.tools.syncingObjects.clearList}";
            // 
            // mainTabDevicesList
            // 
            this.mainTabDevicesList.Controls.Add(this.mainTabDevicesListPanel);
            this.mainTabDevicesList.Location = new System.Drawing.Point(4, 22);
            this.mainTabDevicesList.Name = "mainTabDevicesList";
            this.mainTabDevicesList.Padding = new System.Windows.Forms.Padding(3);
            this.mainTabDevicesList.Size = new System.Drawing.Size(483, 530);
            this.mainTabDevicesList.TabIndex = 2;
            this.mainTabDevicesList.Text = "{main.tab.devicesList}";
            this.mainTabDevicesList.UseVisualStyleBackColor = true;
            // 
            // mainTabDevicesListPanel
            // 
            this.mainTabDevicesListPanel.Controls.Add(this.devicesList);
            this.mainTabDevicesListPanel.Controls.Add(this.toolStrip2);
            this.mainTabDevicesListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabDevicesListPanel.Enabled = false;
            this.mainTabDevicesListPanel.Location = new System.Drawing.Point(3, 3);
            this.mainTabDevicesListPanel.Name = "mainTabDevicesListPanel";
            this.mainTabDevicesListPanel.Size = new System.Drawing.Size(477, 524);
            this.mainTabDevicesListPanel.TabIndex = 0;
            // 
            // devicesList
            // 
            this.devicesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.iconColumnHeaderDevList,
            this.deviceModelColumnHeaderDevList,
            this.deviceUserColumnHeaderDevList,
            this.deviceTypeColumnHeaderDevList});
            this.devicesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicesList.FullRowSelect = true;
            this.devicesList.GridLines = true;
            this.devicesList.LabelWrap = false;
            this.devicesList.Location = new System.Drawing.Point(0, 25);
            this.devicesList.MultiSelect = false;
            this.devicesList.Name = "devicesList";
            this.devicesList.Size = new System.Drawing.Size(477, 499);
            this.devicesList.TabIndex = 3;
            this.devicesList.UseCompatibleStateImageBehavior = false;
            this.devicesList.View = System.Windows.Forms.View.Details;
            // 
            // iconColumnHeaderDevList
            // 
            this.iconColumnHeaderDevList.Text = "";
            this.iconColumnHeaderDevList.Width = 21;
            // 
            // deviceModelColumnHeaderDevList
            // 
            this.deviceModelColumnHeaderDevList.DisplayIndex = 2;
            this.deviceModelColumnHeaderDevList.Text = "{main.list.devicesList.column.model}";
            this.deviceModelColumnHeaderDevList.Width = 205;
            // 
            // deviceUserColumnHeaderDevList
            // 
            this.deviceUserColumnHeaderDevList.DisplayIndex = 1;
            this.deviceUserColumnHeaderDevList.Text = "{main.list.devicesList.column.user}";
            this.deviceUserColumnHeaderDevList.Width = 143;
            // 
            // deviceTypeColumnHeaderDevList
            // 
            this.deviceTypeColumnHeaderDevList.Text = "{main.list.devicesList.column.deviceType}";
            this.deviceTypeColumnHeaderDevList.Width = 82;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devListRestoreData,
            this.devListShowSynced,
            this.toolStripSeparator3,
            this.devListWipeSyncedData});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(477, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // devListRestoreData
            // 
            this.devListRestoreData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.devListRestoreData.Image = ((System.Drawing.Image)(resources.GetObject("devListRestoreData.Image")));
            this.devListRestoreData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.devListRestoreData.Name = "devListRestoreData";
            this.devListRestoreData.Size = new System.Drawing.Size(23, 22);
            this.devListRestoreData.Text = "{main.tools.devicesList.restoreDeviceData}";
            // 
            // devListShowSynced
            // 
            this.devListShowSynced.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.devListShowSynced.Image = ((System.Drawing.Image)(resources.GetObject("devListShowSynced.Image")));
            this.devListShowSynced.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.devListShowSynced.Name = "devListShowSynced";
            this.devListShowSynced.Size = new System.Drawing.Size(23, 22);
            this.devListShowSynced.Text = "{main.tools.devicesList.showSyncedData}";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // devListWipeSyncedData
            // 
            this.devListWipeSyncedData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.devListWipeSyncedData.Image = ((System.Drawing.Image)(resources.GetObject("devListWipeSyncedData.Image")));
            this.devListWipeSyncedData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.devListWipeSyncedData.Name = "devListWipeSyncedData";
            this.devListWipeSyncedData.Size = new System.Drawing.Size(23, 22);
            this.devListWipeSyncedData.Text = "{main.tools.devicesList.wipeSyncedData}";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 602);
            this.Controls.Add(this.tabController);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Synx - {main.title}";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabController.ResumeLayout(false);
            this.mainTabHome.ResumeLayout(false);
            this.mainTabHomePanel.ResumeLayout(false);
            this.mainTabHomePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainTabSyncingObjectsList.ResumeLayout(false);
            this.mainTabSyncingObjects.ResumeLayout(false);
            this.mainTabSyncingObjects.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.mainTabDevicesList.ResumeLayout(false);
            this.mainTabDevicesListPanel.ResumeLayout(false);
            this.mainTabDevicesListPanel.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.TabPage mainTabHome;
        private System.Windows.Forms.TabPage mainTabSyncingObjectsList;
        private System.Windows.Forms.TabPage mainTabDevicesList;
        private System.Windows.Forms.Panel mainTabSyncingObjects;
        private System.Windows.Forms.ListView syncingObjectsList;
        private System.Windows.Forms.ColumnHeader iconColumnHeaderSyncingObjectsList;
        private System.Windows.Forms.ColumnHeader folderNameColumnHeaderSyncingObjectsList;
        private System.Windows.Forms.ColumnHeader folderPathColumnHeaderSyncingObjectsList;
        private System.Windows.Forms.ColumnHeader syncStatusColumnHeaderSyncingObjectsList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel mainTabDevicesListPanel;
        private System.Windows.Forms.ListView devicesList;
        private System.Windows.Forms.ColumnHeader iconColumnHeaderDevList;
        private System.Windows.Forms.ColumnHeader deviceModelColumnHeaderDevList;
        private System.Windows.Forms.ColumnHeader deviceUserColumnHeaderDevList;
        private System.Windows.Forms.ColumnHeader deviceTypeColumnHeaderDevList;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.Panel mainTabHomePanel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.LinkLabel linkCreateServer;
        private System.Windows.Forms.LinkLabel linkConnectToServer;
        private System.Windows.Forms.ToolStripMenuItem synxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuConnectToServer;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuDisconnect;
        private System.Windows.Forms.ToolStripMenuItem mainMenuExit;
        private System.Windows.Forms.ToolStripMenuItem mainMenuHeaderUser;
        private System.Windows.Forms.ToolStripMenuItem mainMenuUserInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mainMenuUserClearAllData;
        private System.Windows.Forms.ToolStripMenuItem mainMenuUserRestoreSynced;
        private System.Windows.Forms.ToolStripMenuItem mainMenuHeaderSync;
        private System.Windows.Forms.ToolStripMenuItem mainMenuSyncStart;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mainMenuSyncStop;
        private System.Windows.Forms.ToolStripMenuItem mainMenuSyncPause;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
        private System.Windows.Forms.ToolStripButton syncingAdd;
        private System.Windows.Forms.ToolStripButton syncingRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton syncingStartSync;
        private System.Windows.Forms.ToolStripButton syncingStopSync;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton syncingClearList;
        private System.Windows.Forms.ToolStripMenuItem mainMenuHeaderService;
        private System.Windows.Forms.ToolStripMenuItem mainMenuServiceSettings;
        private System.Windows.Forms.ToolStripMenuItem mainMenuHeaderHelp;
        private System.Windows.Forms.ToolStripMenuItem mainMenuHelpAbout;
        private System.Windows.Forms.ToolStripButton devListRestoreData;
        private System.Windows.Forms.ToolStripButton devListShowSynced;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton devListWipeSyncedData;
        private System.Windows.Forms.ToolStripProgressBar statusProgress;
        private System.Windows.Forms.ToolStripMenuItem mainMenuServiceLog;
    }
}

