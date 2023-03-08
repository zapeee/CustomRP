namespace CustomRPC
{
	// Token: 0x0200000E RID: 14
	public partial class MainForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600006B RID: 107 RVA: 0x00005E4C File Offset: 0x0000404C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			if (disposing && this.client != null)
			{
				this.client.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00005E84 File Offset: 0x00004084
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::CustomRPC.MainForm));
			this.trayIcon = new global::System.Windows.Forms.NotifyIcon(this.components);
			this.trayMenuStrip = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.openToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorTray1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.trayMenuReconnect = new global::System.Windows.Forms.ToolStripMenuItem();
			this.trayMenuDisconnect = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.trayMenuQuit = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip = new global::System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.loadPresetToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.savePresetToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorFile1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.uploadAssetsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorFile2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.quitToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.runOnStartupToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.startMinimizedToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.autoconnectToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorSettings1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.checkUpdatesToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.allowAnalyticsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorSettings2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.darkModeToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorSettings3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.languageToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.defaultToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.sampleToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.openTheManualToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.gitHubPageToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorHelp1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.supportersToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.testSupporterToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.translatorsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.sampleLanguageToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.samplePersonToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorHelp2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.checkForUpdatesToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.downloadUpdateToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.buttonUpdatePresence = new global::System.Windows.Forms.Button();
			this.buttonConnect = new global::System.Windows.Forms.Button();
			this.buttonDisconnect = new global::System.Windows.Forms.Button();
			this.labelID = new global::System.Windows.Forms.Label();
			this.labelDetails = new global::System.Windows.Forms.Label();
			this.labelState = new global::System.Windows.Forms.Label();
			this.labelSmallKey = new global::System.Windows.Forms.Label();
			this.labelSmallText = new global::System.Windows.Forms.Label();
			this.labelLargeText = new global::System.Windows.Forms.Label();
			this.labelLargeKey = new global::System.Windows.Forms.Label();
			this.labelSmall = new global::System.Windows.Forms.Label();
			this.labelLarge = new global::System.Windows.Forms.Label();
			this.toolTipInfo = new global::System.Windows.Forms.ToolTip(this.components);
			this.radioButtonNone = new global::System.Windows.Forms.RadioButton();
			this.radioButtonStartTime = new global::System.Windows.Forms.RadioButton();
			this.radioButtonLocalTime = new global::System.Windows.Forms.RadioButton();
			this.labelTimestamp = new global::System.Windows.Forms.Label();
			this.labelParty = new global::System.Windows.Forms.Label();
			this.radioButtonCustom = new global::System.Windows.Forms.RadioButton();
			this.labelButton1 = new global::System.Windows.Forms.Label();
			this.labelButton2 = new global::System.Windows.Forms.Label();
			this.labelButton1URL = new global::System.Windows.Forms.Label();
			this.labelButton2URL = new global::System.Windows.Forms.Label();
			this.labelButton1Text = new global::System.Windows.Forms.Label();
			this.labelButton2Text = new global::System.Windows.Forms.Label();
			this.radioButtonPresence = new global::System.Windows.Forms.RadioButton();
			this.panelTimestamps = new global::System.Windows.Forms.Panel();
			this.dateTimePickerTimestamp = new global::System.Windows.Forms.DateTimePicker();
			this.labelPartyOf = new global::System.Windows.Forms.Label();
			this.statusStrip = new global::System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelPadding = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelStatus = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.textBoxButton2Text = new global::System.Windows.Forms.TextBox();
			this.textBoxButton2URL = new global::System.Windows.Forms.TextBox();
			this.textBoxButton1URL = new global::System.Windows.Forms.TextBox();
			this.textBoxButton1Text = new global::System.Windows.Forms.TextBox();
			this.numericUpDownPartySize = new global::System.Windows.Forms.NumericUpDown();
			this.numericUpDownPartyMax = new global::System.Windows.Forms.NumericUpDown();
			this.comboBoxSmallKey = new global::System.Windows.Forms.ComboBox();
			this.textBoxSmallText = new global::System.Windows.Forms.TextBox();
			this.textBoxLargeText = new global::System.Windows.Forms.TextBox();
			this.comboBoxLargeKey = new global::System.Windows.Forms.ComboBox();
			this.textBoxState = new global::System.Windows.Forms.TextBox();
			this.textBoxDetails = new global::System.Windows.Forms.TextBox();
			this.textBoxID = new global::System.Windows.Forms.TextBox();
			this.trayMenuStrip.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.panelTimestamps.SuspendLayout();
			this.statusStrip.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDownPartySize).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDownPartyMax).BeginInit();
			base.SuspendLayout();
			this.trayIcon.BalloonTipIcon = global::System.Windows.Forms.ToolTipIcon.Info;
			componentResourceManager.ApplyResources(this.trayIcon, "trayIcon");
			this.trayIcon.ContextMenuStrip = this.trayMenuStrip;
			this.trayIcon.Icon = global::CustomRPC.Properties.Resources.favicon;
			this.trayIcon.BalloonTipClicked += new global::System.EventHandler(this.MaximizeFromTray);
			this.trayIcon.DoubleClick += new global::System.EventHandler(this.MaximizeFromTray);
			componentResourceManager.ApplyResources(this.trayMenuStrip, "trayMenuStrip");
			this.trayMenuStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.openToolStripMenuItem,
				this.toolStripSeparatorTray1,
				this.trayMenuReconnect,
				this.trayMenuDisconnect,
				this.toolStripSeparator3,
				this.trayMenuQuit
			});
			this.trayMenuStrip.Name = "trayMenuStrip";
			this.toolTipInfo.SetToolTip(this.trayMenuStrip, componentResourceManager.GetString("trayMenuStrip.ToolTip"));
			componentResourceManager.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Click += new global::System.EventHandler(this.MaximizeFromTray);
			componentResourceManager.ApplyResources(this.toolStripSeparatorTray1, "toolStripSeparatorTray1");
			this.toolStripSeparatorTray1.Name = "toolStripSeparatorTray1";
			componentResourceManager.ApplyResources(this.trayMenuReconnect, "trayMenuReconnect");
			this.trayMenuReconnect.Name = "trayMenuReconnect";
			this.trayMenuReconnect.Click += new global::System.EventHandler(this.Connect);
			componentResourceManager.ApplyResources(this.trayMenuDisconnect, "trayMenuDisconnect");
			this.trayMenuDisconnect.Name = "trayMenuDisconnect";
			this.trayMenuDisconnect.Click += new global::System.EventHandler(this.Disconnect);
			componentResourceManager.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			componentResourceManager.ApplyResources(this.trayMenuQuit, "trayMenuQuit");
			this.trayMenuQuit.Name = "trayMenuQuit";
			this.trayMenuQuit.Click += new global::System.EventHandler(this.Quit);
			componentResourceManager.ApplyResources(this.menuStrip, "menuStrip");
			this.menuStrip.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.menuStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.fileToolStripMenuItem,
				this.settingsToolStripMenuItem,
				this.helpToolStripMenuItem,
				this.downloadUpdateToolStripMenuItem
			});
			this.menuStrip.Name = "menuStrip";
			this.toolTipInfo.SetToolTip(this.menuStrip, componentResourceManager.GetString("menuStrip.ToolTip"));
			componentResourceManager.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
			this.fileToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.loadPresetToolStripMenuItem,
				this.savePresetToolStripMenuItem,
				this.toolStripSeparatorFile1,
				this.uploadAssetsToolStripMenuItem,
				this.toolStripSeparatorFile2,
				this.quitToolStripMenuItem
			});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			componentResourceManager.ApplyResources(this.loadPresetToolStripMenuItem, "loadPresetToolStripMenuItem");
			this.loadPresetToolStripMenuItem.Name = "loadPresetToolStripMenuItem";
			this.loadPresetToolStripMenuItem.Click += new global::System.EventHandler(this.LoadPreset);
			componentResourceManager.ApplyResources(this.savePresetToolStripMenuItem, "savePresetToolStripMenuItem");
			this.savePresetToolStripMenuItem.Name = "savePresetToolStripMenuItem";
			this.savePresetToolStripMenuItem.Click += new global::System.EventHandler(this.SavePreset);
			componentResourceManager.ApplyResources(this.toolStripSeparatorFile1, "toolStripSeparatorFile1");
			this.toolStripSeparatorFile1.Name = "toolStripSeparatorFile1";
			componentResourceManager.ApplyResources(this.uploadAssetsToolStripMenuItem, "uploadAssetsToolStripMenuItem");
			this.uploadAssetsToolStripMenuItem.Name = "uploadAssetsToolStripMenuItem";
			this.uploadAssetsToolStripMenuItem.Click += new global::System.EventHandler(this.OpenDiscordSite);
			componentResourceManager.ApplyResources(this.toolStripSeparatorFile2, "toolStripSeparatorFile2");
			this.toolStripSeparatorFile2.Name = "toolStripSeparatorFile2";
			componentResourceManager.ApplyResources(this.quitToolStripMenuItem, "quitToolStripMenuItem");
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Click += new global::System.EventHandler(this.Quit);
			componentResourceManager.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
			this.settingsToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.runOnStartupToolStripMenuItem,
				this.startMinimizedToolStripMenuItem,
				this.autoconnectToolStripMenuItem,
				this.toolStripSeparatorSettings1,
				this.checkUpdatesToolStripMenuItem,
				this.allowAnalyticsToolStripMenuItem,
				this.toolStripSeparatorSettings2,
				this.darkModeToolStripMenuItem,
				this.toolStripSeparatorSettings3,
				this.languageToolStripMenuItem
			});
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			componentResourceManager.ApplyResources(this.runOnStartupToolStripMenuItem, "runOnStartupToolStripMenuItem");
			this.runOnStartupToolStripMenuItem.Checked = true;
			this.runOnStartupToolStripMenuItem.CheckOnClick = true;
			this.runOnStartupToolStripMenuItem.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.runOnStartupToolStripMenuItem.Name = "runOnStartupToolStripMenuItem";
			this.runOnStartupToolStripMenuItem.CheckedChanged += new global::System.EventHandler(this.SaveMenuSettings);
			componentResourceManager.ApplyResources(this.startMinimizedToolStripMenuItem, "startMinimizedToolStripMenuItem");
			this.startMinimizedToolStripMenuItem.CheckOnClick = true;
			this.startMinimizedToolStripMenuItem.Name = "startMinimizedToolStripMenuItem";
			this.startMinimizedToolStripMenuItem.CheckedChanged += new global::System.EventHandler(this.SaveMenuSettings);
			componentResourceManager.ApplyResources(this.autoconnectToolStripMenuItem, "autoconnectToolStripMenuItem");
			this.autoconnectToolStripMenuItem.Checked = true;
			this.autoconnectToolStripMenuItem.CheckOnClick = true;
			this.autoconnectToolStripMenuItem.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.autoconnectToolStripMenuItem.Name = "autoconnectToolStripMenuItem";
			this.autoconnectToolStripMenuItem.CheckedChanged += new global::System.EventHandler(this.SaveMenuSettings);
			componentResourceManager.ApplyResources(this.toolStripSeparatorSettings1, "toolStripSeparatorSettings1");
			this.toolStripSeparatorSettings1.Name = "toolStripSeparatorSettings1";
			componentResourceManager.ApplyResources(this.checkUpdatesToolStripMenuItem, "checkUpdatesToolStripMenuItem");
			this.checkUpdatesToolStripMenuItem.Checked = true;
			this.checkUpdatesToolStripMenuItem.CheckOnClick = true;
			this.checkUpdatesToolStripMenuItem.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkUpdatesToolStripMenuItem.Name = "checkUpdatesToolStripMenuItem";
			this.checkUpdatesToolStripMenuItem.CheckedChanged += new global::System.EventHandler(this.SaveMenuSettings);
			componentResourceManager.ApplyResources(this.allowAnalyticsToolStripMenuItem, "allowAnalyticsToolStripMenuItem");
			this.allowAnalyticsToolStripMenuItem.Checked = true;
			this.allowAnalyticsToolStripMenuItem.CheckOnClick = true;
			this.allowAnalyticsToolStripMenuItem.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.allowAnalyticsToolStripMenuItem.Name = "allowAnalyticsToolStripMenuItem";
			this.allowAnalyticsToolStripMenuItem.CheckedChanged += new global::System.EventHandler(this.SaveMenuSettings);
			componentResourceManager.ApplyResources(this.toolStripSeparatorSettings2, "toolStripSeparatorSettings2");
			this.toolStripSeparatorSettings2.Name = "toolStripSeparatorSettings2";
			componentResourceManager.ApplyResources(this.darkModeToolStripMenuItem, "darkModeToolStripMenuItem");
			this.darkModeToolStripMenuItem.CheckOnClick = true;
			this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
			this.darkModeToolStripMenuItem.CheckedChanged += new global::System.EventHandler(this.SaveMenuSettings);
			componentResourceManager.ApplyResources(this.toolStripSeparatorSettings3, "toolStripSeparatorSettings3");
			this.toolStripSeparatorSettings3.Name = "toolStripSeparatorSettings3";
			componentResourceManager.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
			this.languageToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.defaultToolStripMenuItem,
				this.toolStripSeparator2,
				this.sampleToolStripMenuItem
			});
			this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
			componentResourceManager.ApplyResources(this.defaultToolStripMenuItem, "defaultToolStripMenuItem");
			this.defaultToolStripMenuItem.CheckOnClick = true;
			this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
			this.defaultToolStripMenuItem.Tag = "auto";
			this.defaultToolStripMenuItem.Click += new global::System.EventHandler(this.ChangeLanguage);
			componentResourceManager.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			componentResourceManager.ApplyResources(this.sampleToolStripMenuItem, "sampleToolStripMenuItem");
			this.sampleToolStripMenuItem.Name = "sampleToolStripMenuItem";
			this.sampleToolStripMenuItem.Tag = "lol";
			this.sampleToolStripMenuItem.Click += new global::System.EventHandler(this.ChangeLanguage);
			componentResourceManager.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
			this.helpToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.openTheManualToolStripMenuItem,
				this.gitHubPageToolStripMenuItem,
				this.toolStripSeparatorHelp1,
				this.supportersToolStripMenuItem,
				this.translatorsToolStripMenuItem,
				this.toolStripSeparatorHelp2,
				this.checkForUpdatesToolStripMenuItem,
				this.aboutToolStripMenuItem
			});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			componentResourceManager.ApplyResources(this.openTheManualToolStripMenuItem, "openTheManualToolStripMenuItem");
			this.openTheManualToolStripMenuItem.Name = "openTheManualToolStripMenuItem";
			this.openTheManualToolStripMenuItem.Tag = "https://docs.customrp.xyz/setting-up";
			this.openTheManualToolStripMenuItem.Click += new global::System.EventHandler(this.OpenSite);
			componentResourceManager.ApplyResources(this.gitHubPageToolStripMenuItem, "gitHubPageToolStripMenuItem");
			this.gitHubPageToolStripMenuItem.Name = "gitHubPageToolStripMenuItem";
			this.gitHubPageToolStripMenuItem.Tag = "https://github.com/maximmax42/Discord-CustomRP";
			this.gitHubPageToolStripMenuItem.Click += new global::System.EventHandler(this.OpenSite);
			componentResourceManager.ApplyResources(this.toolStripSeparatorHelp1, "toolStripSeparatorHelp1");
			this.toolStripSeparatorHelp1.Name = "toolStripSeparatorHelp1";
			componentResourceManager.ApplyResources(this.supportersToolStripMenuItem, "supportersToolStripMenuItem");
			this.supportersToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.testSupporterToolStripMenuItem
			});
			this.supportersToolStripMenuItem.Name = "supportersToolStripMenuItem";
			componentResourceManager.ApplyResources(this.testSupporterToolStripMenuItem, "testSupporterToolStripMenuItem");
			this.testSupporterToolStripMenuItem.Name = "testSupporterToolStripMenuItem";
			componentResourceManager.ApplyResources(this.translatorsToolStripMenuItem, "translatorsToolStripMenuItem");
			this.translatorsToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.sampleLanguageToolStripMenuItem
			});
			this.translatorsToolStripMenuItem.Name = "translatorsToolStripMenuItem";
			componentResourceManager.ApplyResources(this.sampleLanguageToolStripMenuItem, "sampleLanguageToolStripMenuItem");
			this.sampleLanguageToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.samplePersonToolStripMenuItem
			});
			this.sampleLanguageToolStripMenuItem.Name = "sampleLanguageToolStripMenuItem";
			componentResourceManager.ApplyResources(this.samplePersonToolStripMenuItem, "samplePersonToolStripMenuItem");
			this.samplePersonToolStripMenuItem.Name = "samplePersonToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripSeparatorHelp2, "toolStripSeparatorHelp2");
			this.toolStripSeparatorHelp2.Name = "toolStripSeparatorHelp2";
			componentResourceManager.ApplyResources(this.checkForUpdatesToolStripMenuItem, "checkForUpdatesToolStripMenuItem");
			this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
			this.checkForUpdatesToolStripMenuItem.Click += new global::System.EventHandler(this.CheckForUpdates);
			componentResourceManager.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
			this.aboutToolStripMenuItem.Image = global::CustomRPC.Properties.Resources.logo;
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Click += new global::System.EventHandler(this.ShowAbout);
			componentResourceManager.ApplyResources(this.downloadUpdateToolStripMenuItem, "downloadUpdateToolStripMenuItem");
			this.downloadUpdateToolStripMenuItem.ForeColor = global::System.Drawing.Color.Red;
			this.downloadUpdateToolStripMenuItem.Name = "downloadUpdateToolStripMenuItem";
			this.downloadUpdateToolStripMenuItem.Click += new global::System.EventHandler(this.DownloadUpdate);
			componentResourceManager.ApplyResources(this.buttonUpdatePresence, "buttonUpdatePresence");
			this.buttonUpdatePresence.AutoEllipsis = true;
			this.buttonUpdatePresence.BackColor = global::System.Drawing.Color.FromArgb(24, 25, 28);
			this.buttonUpdatePresence.FlatAppearance.BorderSize = 0;
			this.buttonUpdatePresence.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(61, 73, 162);
			this.buttonUpdatePresence.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(72, 86, 193);
			this.buttonUpdatePresence.Name = "buttonUpdatePresence";
			this.toolTipInfo.SetToolTip(this.buttonUpdatePresence, componentResourceManager.GetString("buttonUpdatePresence.ToolTip"));
			this.buttonUpdatePresence.UseVisualStyleBackColor = true;
			this.buttonUpdatePresence.Click += new global::System.EventHandler(this.Update);
			this.buttonUpdatePresence.Paint += new global::System.Windows.Forms.PaintEventHandler(this.ButtonPaint);
			componentResourceManager.ApplyResources(this.buttonConnect, "buttonConnect");
			this.buttonConnect.AutoEllipsis = true;
			this.buttonConnect.BackColor = global::System.Drawing.Color.FromArgb(24, 25, 28);
			this.buttonConnect.FlatAppearance.BorderSize = 0;
			this.buttonConnect.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(61, 73, 162);
			this.buttonConnect.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(72, 86, 193);
			this.buttonConnect.Name = "buttonConnect";
			this.toolTipInfo.SetToolTip(this.buttonConnect, componentResourceManager.GetString("buttonConnect.ToolTip"));
			this.buttonConnect.UseVisualStyleBackColor = true;
			this.buttonConnect.Click += new global::System.EventHandler(this.Connect);
			this.buttonConnect.Paint += new global::System.Windows.Forms.PaintEventHandler(this.ButtonPaint);
			componentResourceManager.ApplyResources(this.buttonDisconnect, "buttonDisconnect");
			this.buttonDisconnect.AutoEllipsis = true;
			this.buttonDisconnect.BackColor = global::System.Drawing.Color.FromArgb(24, 25, 28);
			this.buttonDisconnect.FlatAppearance.BorderSize = 0;
			this.buttonDisconnect.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(61, 73, 162);
			this.buttonDisconnect.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(72, 86, 193);
			this.buttonDisconnect.Name = "buttonDisconnect";
			this.toolTipInfo.SetToolTip(this.buttonDisconnect, componentResourceManager.GetString("buttonDisconnect.ToolTip"));
			this.buttonDisconnect.UseVisualStyleBackColor = true;
			this.buttonDisconnect.Click += new global::System.EventHandler(this.Disconnect);
			this.buttonDisconnect.Paint += new global::System.Windows.Forms.PaintEventHandler(this.ButtonPaint);
			componentResourceManager.ApplyResources(this.labelID, "labelID");
			this.labelID.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.labelID.Name = "labelID";
			this.toolTipInfo.SetToolTip(this.labelID, componentResourceManager.GetString("labelID.ToolTip"));
			componentResourceManager.ApplyResources(this.labelDetails, "labelDetails");
			this.labelDetails.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.labelDetails.Name = "labelDetails";
			this.toolTipInfo.SetToolTip(this.labelDetails, componentResourceManager.GetString("labelDetails.ToolTip"));
			componentResourceManager.ApplyResources(this.labelState, "labelState");
			this.labelState.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.labelState.Name = "labelState";
			this.toolTipInfo.SetToolTip(this.labelState, componentResourceManager.GetString("labelState.ToolTip"));
			componentResourceManager.ApplyResources(this.labelSmallKey, "labelSmallKey");
			this.labelSmallKey.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.labelSmallKey.Name = "labelSmallKey";
			this.toolTipInfo.SetToolTip(this.labelSmallKey, componentResourceManager.GetString("labelSmallKey.ToolTip"));
			componentResourceManager.ApplyResources(this.labelSmallText, "labelSmallText");
			this.labelSmallText.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.labelSmallText.Name = "labelSmallText";
			this.toolTipInfo.SetToolTip(this.labelSmallText, componentResourceManager.GetString("labelSmallText.ToolTip"));
			componentResourceManager.ApplyResources(this.labelLargeText, "labelLargeText");
			this.labelLargeText.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.labelLargeText.Name = "labelLargeText";
			this.toolTipInfo.SetToolTip(this.labelLargeText, componentResourceManager.GetString("labelLargeText.ToolTip"));
			componentResourceManager.ApplyResources(this.labelLargeKey, "labelLargeKey");
			this.labelLargeKey.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.labelLargeKey.Name = "labelLargeKey";
			this.toolTipInfo.SetToolTip(this.labelLargeKey, componentResourceManager.GetString("labelLargeKey.ToolTip"));
			componentResourceManager.ApplyResources(this.labelSmall, "labelSmall");
			this.labelSmall.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.labelSmall.Name = "labelSmall";
			this.toolTipInfo.SetToolTip(this.labelSmall, componentResourceManager.GetString("labelSmall.ToolTip"));
			componentResourceManager.ApplyResources(this.labelLarge, "labelLarge");
			this.labelLarge.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.labelLarge.Name = "labelLarge";
			this.toolTipInfo.SetToolTip(this.labelLarge, componentResourceManager.GetString("labelLarge.ToolTip"));
			this.toolTipInfo.ToolTipIcon = global::System.Windows.Forms.ToolTipIcon.Info;
			this.toolTipInfo.ToolTipTitle = "Information";
			componentResourceManager.ApplyResources(this.radioButtonNone, "radioButtonNone");
			this.radioButtonNone.Name = "radioButtonNone";
			this.radioButtonNone.TabStop = true;
			this.radioButtonNone.Tag = "";
			this.toolTipInfo.SetToolTip(this.radioButtonNone, componentResourceManager.GetString("radioButtonNone.ToolTip"));
			this.radioButtonNone.UseVisualStyleBackColor = true;
			this.radioButtonNone.CheckedChanged += new global::System.EventHandler(this.TimestampsChanged);
			componentResourceManager.ApplyResources(this.radioButtonStartTime, "radioButtonStartTime");
			this.radioButtonStartTime.Name = "radioButtonStartTime";
			this.radioButtonStartTime.TabStop = true;
			this.radioButtonStartTime.Tag = "";
			this.toolTipInfo.SetToolTip(this.radioButtonStartTime, componentResourceManager.GetString("radioButtonStartTime.ToolTip"));
			this.radioButtonStartTime.UseVisualStyleBackColor = true;
			this.radioButtonStartTime.CheckedChanged += new global::System.EventHandler(this.TimestampsChanged);
			componentResourceManager.ApplyResources(this.radioButtonLocalTime, "radioButtonLocalTime");
			this.radioButtonLocalTime.Name = "radioButtonLocalTime";
			this.radioButtonLocalTime.TabStop = true;
			this.radioButtonLocalTime.Tag = "";
			this.toolTipInfo.SetToolTip(this.radioButtonLocalTime, componentResourceManager.GetString("radioButtonLocalTime.ToolTip"));
			this.radioButtonLocalTime.UseVisualStyleBackColor = true;
			this.radioButtonLocalTime.CheckedChanged += new global::System.EventHandler(this.TimestampsChanged);
			componentResourceManager.ApplyResources(this.labelTimestamp, "labelTimestamp");
			this.labelTimestamp.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.labelTimestamp.Name = "labelTimestamp";
			this.toolTipInfo.SetToolTip(this.labelTimestamp, componentResourceManager.GetString("labelTimestamp.ToolTip"));
			componentResourceManager.ApplyResources(this.labelParty, "labelParty");
			this.labelParty.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.labelParty.Name = "labelParty";
			this.toolTipInfo.SetToolTip(this.labelParty, componentResourceManager.GetString("labelParty.ToolTip"));
			componentResourceManager.ApplyResources(this.radioButtonCustom, "radioButtonCustom");
			this.radioButtonCustom.Name = "radioButtonCustom";
			this.radioButtonCustom.TabStop = true;
			this.radioButtonCustom.Tag = "";
			this.toolTipInfo.SetToolTip(this.radioButtonCustom, componentResourceManager.GetString("radioButtonCustom.ToolTip"));
			this.radioButtonCustom.UseVisualStyleBackColor = true;
			this.radioButtonCustom.CheckedChanged += new global::System.EventHandler(this.TimestampsChanged);
			componentResourceManager.ApplyResources(this.labelButton1, "labelButton1");
			this.labelButton1.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.labelButton1.Name = "labelButton1";
			this.toolTipInfo.SetToolTip(this.labelButton1, componentResourceManager.GetString("labelButton1.ToolTip"));
			componentResourceManager.ApplyResources(this.labelButton2, "labelButton2");
			this.labelButton2.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.labelButton2.Name = "labelButton2";
			this.toolTipInfo.SetToolTip(this.labelButton2, componentResourceManager.GetString("labelButton2.ToolTip"));
			componentResourceManager.ApplyResources(this.labelButton1URL, "labelButton1URL");
			this.labelButton1URL.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.labelButton1URL.Name = "labelButton1URL";
			this.toolTipInfo.SetToolTip(this.labelButton1URL, componentResourceManager.GetString("labelButton1URL.ToolTip"));
			componentResourceManager.ApplyResources(this.labelButton2URL, "labelButton2URL");
			this.labelButton2URL.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.labelButton2URL.Name = "labelButton2URL";
			this.toolTipInfo.SetToolTip(this.labelButton2URL, componentResourceManager.GetString("labelButton2URL.ToolTip"));
			componentResourceManager.ApplyResources(this.labelButton1Text, "labelButton1Text");
			this.labelButton1Text.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.labelButton1Text.Name = "labelButton1Text";
			this.toolTipInfo.SetToolTip(this.labelButton1Text, componentResourceManager.GetString("labelButton1Text.ToolTip"));
			componentResourceManager.ApplyResources(this.labelButton2Text, "labelButton2Text");
			this.labelButton2Text.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.labelButton2Text.Name = "labelButton2Text";
			this.toolTipInfo.SetToolTip(this.labelButton2Text, componentResourceManager.GetString("labelButton2Text.ToolTip"));
			componentResourceManager.ApplyResources(this.radioButtonPresence, "radioButtonPresence");
			this.radioButtonPresence.Name = "radioButtonPresence";
			this.radioButtonPresence.TabStop = true;
			this.radioButtonPresence.Tag = "";
			this.toolTipInfo.SetToolTip(this.radioButtonPresence, componentResourceManager.GetString("radioButtonPresence.ToolTip"));
			this.radioButtonPresence.UseVisualStyleBackColor = true;
			this.radioButtonPresence.CheckedChanged += new global::System.EventHandler(this.TimestampsChanged);
			componentResourceManager.ApplyResources(this.panelTimestamps, "panelTimestamps");
			this.panelTimestamps.Controls.Add(this.radioButtonPresence);
			this.panelTimestamps.Controls.Add(this.dateTimePickerTimestamp);
			this.panelTimestamps.Controls.Add(this.radioButtonCustom);
			this.panelTimestamps.Controls.Add(this.radioButtonLocalTime);
			this.panelTimestamps.Controls.Add(this.radioButtonNone);
			this.panelTimestamps.Controls.Add(this.radioButtonStartTime);
			this.panelTimestamps.Name = "panelTimestamps";
			this.toolTipInfo.SetToolTip(this.panelTimestamps, componentResourceManager.GetString("panelTimestamps.ToolTip"));
			componentResourceManager.ApplyResources(this.dateTimePickerTimestamp, "dateTimePickerTimestamp");
			this.dateTimePickerTimestamp.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", global::CustomRPC.Properties.Settings.Default, "customTimestamp", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.dateTimePickerTimestamp.Format = global::System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerTimestamp.MinDate = new global::System.DateTime(1969, 1, 1, 0, 0, 0, 0);
			this.dateTimePickerTimestamp.Name = "dateTimePickerTimestamp";
			this.toolTipInfo.SetToolTip(this.dateTimePickerTimestamp, componentResourceManager.GetString("dateTimePickerTimestamp.ToolTip"));
			this.dateTimePickerTimestamp.Value = global::CustomRPC.Properties.Settings.Default.customTimestamp;
			componentResourceManager.ApplyResources(this.labelPartyOf, "labelPartyOf");
			this.labelPartyOf.Name = "labelPartyOf";
			this.toolTipInfo.SetToolTip(this.labelPartyOf, componentResourceManager.GetString("labelPartyOf.ToolTip"));
			componentResourceManager.ApplyResources(this.statusStrip, "statusStrip");
			this.statusStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripStatusLabelPadding,
				this.toolStripStatusLabelStatus
			});
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.SizingGrip = false;
			this.toolTipInfo.SetToolTip(this.statusStrip, componentResourceManager.GetString("statusStrip.ToolTip"));
			componentResourceManager.ApplyResources(this.toolStripStatusLabelPadding, "toolStripStatusLabelPadding");
			this.toolStripStatusLabelPadding.Name = "toolStripStatusLabelPadding";
			this.toolStripStatusLabelPadding.Spring = true;
			componentResourceManager.ApplyResources(this.toolStripStatusLabelStatus, "toolStripStatusLabelStatus");
			this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
			componentResourceManager.ApplyResources(this.textBoxButton2Text, "textBoxButton2Text");
			this.textBoxButton2Text.BackColor = global::System.Drawing.Color.FromArgb(65, 68, 75);
			this.textBoxButton2Text.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", global::CustomRPC.Properties.Settings.Default, "button2Text", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxButton2Text.ForeColor = global::System.Drawing.Color.White;
			this.textBoxButton2Text.Name = "textBoxButton2Text";
			this.textBoxButton2Text.Text = global::CustomRPC.Properties.Settings.Default.button2Text;
			this.toolTipInfo.SetToolTip(this.textBoxButton2Text, componentResourceManager.GetString("textBoxButton2Text.ToolTip"));
			this.textBoxButton2Text.TextChanged += new global::System.EventHandler(this.LengthValidation);
			this.textBoxButton2Text.Validating += new global::System.ComponentModel.CancelEventHandler(this.LengthValidationFocus);
			componentResourceManager.ApplyResources(this.textBoxButton2URL, "textBoxButton2URL");
			this.textBoxButton2URL.BackColor = global::System.Drawing.Color.FromArgb(65, 68, 75);
			this.textBoxButton2URL.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", global::CustomRPC.Properties.Settings.Default, "button2Url", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxButton2URL.ForeColor = global::System.Drawing.Color.White;
			this.textBoxButton2URL.Name = "textBoxButton2URL";
			this.textBoxButton2URL.Text = global::CustomRPC.Properties.Settings.Default.button2URL;
			this.toolTipInfo.SetToolTip(this.textBoxButton2URL, componentResourceManager.GetString("textBoxButton2URL.ToolTip"));
			this.textBoxButton2URL.TextChanged += new global::System.EventHandler(this.LengthValidation);
			this.textBoxButton2URL.Validating += new global::System.ComponentModel.CancelEventHandler(this.LengthValidationFocus);
			componentResourceManager.ApplyResources(this.textBoxButton1URL, "textBoxButton1URL");
			this.textBoxButton1URL.BackColor = global::System.Drawing.Color.FromArgb(65, 68, 75);
			this.textBoxButton1URL.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", global::CustomRPC.Properties.Settings.Default, "button1Url", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxButton1URL.ForeColor = global::System.Drawing.Color.White;
			this.textBoxButton1URL.Name = "textBoxButton1URL";
			this.textBoxButton1URL.Text = global::CustomRPC.Properties.Settings.Default.button1URL;
			this.toolTipInfo.SetToolTip(this.textBoxButton1URL, componentResourceManager.GetString("textBoxButton1URL.ToolTip"));
			this.textBoxButton1URL.TextChanged += new global::System.EventHandler(this.LengthValidation);
			this.textBoxButton1URL.Validating += new global::System.ComponentModel.CancelEventHandler(this.LengthValidationFocus);
			componentResourceManager.ApplyResources(this.textBoxButton1Text, "textBoxButton1Text");
			this.textBoxButton1Text.BackColor = global::System.Drawing.Color.FromArgb(65, 68, 75);
			this.textBoxButton1Text.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", global::CustomRPC.Properties.Settings.Default, "button1Text", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxButton1Text.ForeColor = global::System.Drawing.Color.White;
			this.textBoxButton1Text.Name = "textBoxButton1Text";
			this.textBoxButton1Text.Text = global::CustomRPC.Properties.Settings.Default.button1Text;
			this.toolTipInfo.SetToolTip(this.textBoxButton1Text, componentResourceManager.GetString("textBoxButton1Text.ToolTip"));
			this.textBoxButton1Text.TextChanged += new global::System.EventHandler(this.LengthValidation);
			this.textBoxButton1Text.Validating += new global::System.ComponentModel.CancelEventHandler(this.LengthValidationFocus);
			componentResourceManager.ApplyResources(this.numericUpDownPartySize, "numericUpDownPartySize");
			this.numericUpDownPartySize.BackColor = global::System.Drawing.Color.FromArgb(55, 57, 63);
			this.numericUpDownPartySize.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", global::CustomRPC.Properties.Settings.Default, "partySize", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.numericUpDownPartySize.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDownPartySize;
			int[] array = new int[4];
			array[0] = int.MaxValue;
			numericUpDown.Maximum = new decimal(array);
			this.numericUpDownPartySize.Name = "numericUpDownPartySize";
			this.toolTipInfo.SetToolTip(this.numericUpDownPartySize, componentResourceManager.GetString("numericUpDownPartySize.ToolTip"));
			this.numericUpDownPartySize.Value = global::CustomRPC.Properties.Settings.Default.partySize;
			this.numericUpDownPartySize.Validating += new global::System.ComponentModel.CancelEventHandler(this.PartySizeValidation);
			componentResourceManager.ApplyResources(this.numericUpDownPartyMax, "numericUpDownPartyMax");
			this.numericUpDownPartyMax.BackColor = global::System.Drawing.Color.FromArgb(55, 57, 63);
			this.numericUpDownPartyMax.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", global::CustomRPC.Properties.Settings.Default, "partyMax", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.numericUpDownPartyMax.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericUpDownPartyMax;
			int[] array2 = new int[4];
			array2[0] = int.MaxValue;
			numericUpDown2.Maximum = new decimal(array2);
			this.numericUpDownPartyMax.Name = "numericUpDownPartyMax";
			this.toolTipInfo.SetToolTip(this.numericUpDownPartyMax, componentResourceManager.GetString("numericUpDownPartyMax.ToolTip"));
			this.numericUpDownPartyMax.Value = global::CustomRPC.Properties.Settings.Default.partyMax;
			this.numericUpDownPartyMax.Validating += new global::System.ComponentModel.CancelEventHandler(this.PartySizeValidation);
			componentResourceManager.ApplyResources(this.comboBoxSmallKey, "comboBoxSmallKey");
			this.comboBoxSmallKey.BackColor = global::System.Drawing.Color.FromArgb(65, 68, 75);
			this.comboBoxSmallKey.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", global::CustomRPC.Properties.Settings.Default, "smallKey", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.comboBoxSmallKey.ForeColor = global::System.Drawing.Color.White;
			this.comboBoxSmallKey.Name = "comboBoxSmallKey";
			this.comboBoxSmallKey.Sorted = true;
			this.comboBoxSmallKey.Text = global::CustomRPC.Properties.Settings.Default.smallKey;
			this.toolTipInfo.SetToolTip(this.comboBoxSmallKey, componentResourceManager.GetString("comboBoxSmallKey.ToolTip"));
			this.comboBoxSmallKey.DropDown += new global::System.EventHandler(this.FetchAssets);
			this.comboBoxSmallKey.TextChanged += new global::System.EventHandler(this.LengthValidation);
			this.comboBoxSmallKey.Validating += new global::System.ComponentModel.CancelEventHandler(this.LengthValidationFocus);
			componentResourceManager.ApplyResources(this.textBoxSmallText, "textBoxSmallText");
			this.textBoxSmallText.BackColor = global::System.Drawing.Color.FromArgb(65, 68, 75);
			this.textBoxSmallText.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", global::CustomRPC.Properties.Settings.Default, "smallText", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxSmallText.ForeColor = global::System.Drawing.Color.White;
			this.textBoxSmallText.Name = "textBoxSmallText";
			this.textBoxSmallText.Text = global::CustomRPC.Properties.Settings.Default.smallText;
			this.toolTipInfo.SetToolTip(this.textBoxSmallText, componentResourceManager.GetString("textBoxSmallText.ToolTip"));
			this.textBoxSmallText.TextChanged += new global::System.EventHandler(this.LengthValidation);
			this.textBoxSmallText.Validating += new global::System.ComponentModel.CancelEventHandler(this.LengthValidationFocus);
			componentResourceManager.ApplyResources(this.textBoxLargeText, "textBoxLargeText");
			this.textBoxLargeText.BackColor = global::System.Drawing.Color.FromArgb(65, 68, 75);
			this.textBoxLargeText.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", global::CustomRPC.Properties.Settings.Default, "largeText", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxLargeText.ForeColor = global::System.Drawing.Color.White;
			this.textBoxLargeText.Name = "textBoxLargeText";
			this.textBoxLargeText.Text = global::CustomRPC.Properties.Settings.Default.largeText;
			this.toolTipInfo.SetToolTip(this.textBoxLargeText, componentResourceManager.GetString("textBoxLargeText.ToolTip"));
			this.textBoxLargeText.TextChanged += new global::System.EventHandler(this.LengthValidation);
			this.textBoxLargeText.Validating += new global::System.ComponentModel.CancelEventHandler(this.LengthValidationFocus);
			componentResourceManager.ApplyResources(this.comboBoxLargeKey, "comboBoxLargeKey");
			this.comboBoxLargeKey.BackColor = global::System.Drawing.Color.FromArgb(65, 68, 75);
			this.comboBoxLargeKey.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", global::CustomRPC.Properties.Settings.Default, "largeKey", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.comboBoxLargeKey.ForeColor = global::System.Drawing.Color.White;
			this.comboBoxLargeKey.Name = "comboBoxLargeKey";
			this.comboBoxLargeKey.Sorted = true;
			this.comboBoxLargeKey.Text = global::CustomRPC.Properties.Settings.Default.largeKey;
			this.toolTipInfo.SetToolTip(this.comboBoxLargeKey, componentResourceManager.GetString("comboBoxLargeKey.ToolTip"));
			this.comboBoxLargeKey.DropDown += new global::System.EventHandler(this.FetchAssets);
			this.comboBoxLargeKey.TextChanged += new global::System.EventHandler(this.LengthValidation);
			this.comboBoxLargeKey.Validating += new global::System.ComponentModel.CancelEventHandler(this.LengthValidationFocus);
			componentResourceManager.ApplyResources(this.textBoxState, "textBoxState");
			this.textBoxState.BackColor = global::System.Drawing.Color.FromArgb(65, 68, 75);
			this.textBoxState.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", global::CustomRPC.Properties.Settings.Default, "state", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxState.ForeColor = global::System.Drawing.Color.White;
			this.textBoxState.Name = "textBoxState";
			this.textBoxState.Text = global::CustomRPC.Properties.Settings.Default.state;
			this.toolTipInfo.SetToolTip(this.textBoxState, componentResourceManager.GetString("textBoxState.ToolTip"));
			this.textBoxState.TextChanged += new global::System.EventHandler(this.LengthValidation);
			this.textBoxState.Validating += new global::System.ComponentModel.CancelEventHandler(this.LengthValidationFocus);
			componentResourceManager.ApplyResources(this.textBoxDetails, "textBoxDetails");
			this.textBoxDetails.BackColor = global::System.Drawing.Color.FromArgb(65, 68, 75);
			this.textBoxDetails.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", global::CustomRPC.Properties.Settings.Default, "details", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxDetails.ForeColor = global::System.Drawing.Color.White;
			this.textBoxDetails.Name = "textBoxDetails";
			this.textBoxDetails.Text = global::CustomRPC.Properties.Settings.Default.details;
			this.toolTipInfo.SetToolTip(this.textBoxDetails, componentResourceManager.GetString("textBoxDetails.ToolTip"));
			this.textBoxDetails.TextChanged += new global::System.EventHandler(this.LengthValidation);
			this.textBoxDetails.Validating += new global::System.ComponentModel.CancelEventHandler(this.LengthValidationFocus);
			componentResourceManager.ApplyResources(this.textBoxID, "textBoxID");
			this.textBoxID.BackColor = global::System.Drawing.Color.FromArgb(65, 68, 75);
			this.textBoxID.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", global::CustomRPC.Properties.Settings.Default, "id", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxID.ForeColor = global::System.Drawing.Color.White;
			this.textBoxID.Name = "textBoxID";
			this.textBoxID.Text = global::CustomRPC.Properties.Settings.Default.id;
			this.toolTipInfo.SetToolTip(this.textBoxID, componentResourceManager.GetString("textBoxID.ToolTip"));
			this.textBoxID.TextChanged += new global::System.EventHandler(this.OnlyNumbers);
			componentResourceManager.ApplyResources(this, "$this");
			this.AllowDrop = true;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(55, 57, 63);
			base.Controls.Add(this.labelButton2Text);
			base.Controls.Add(this.labelButton1Text);
			base.Controls.Add(this.labelButton2URL);
			base.Controls.Add(this.textBoxButton2Text);
			base.Controls.Add(this.textBoxButton2URL);
			base.Controls.Add(this.labelButton1);
			base.Controls.Add(this.labelButton2);
			base.Controls.Add(this.labelButton1URL);
			base.Controls.Add(this.textBoxButton1URL);
			base.Controls.Add(this.textBoxButton1Text);
			base.Controls.Add(this.statusStrip);
			base.Controls.Add(this.numericUpDownPartySize);
			base.Controls.Add(this.numericUpDownPartyMax);
			base.Controls.Add(this.labelPartyOf);
			base.Controls.Add(this.labelParty);
			base.Controls.Add(this.labelTimestamp);
			base.Controls.Add(this.panelTimestamps);
			base.Controls.Add(this.comboBoxSmallKey);
			base.Controls.Add(this.textBoxSmallText);
			base.Controls.Add(this.labelSmallKey);
			base.Controls.Add(this.labelSmallText);
			base.Controls.Add(this.labelLarge);
			base.Controls.Add(this.labelSmall);
			base.Controls.Add(this.labelLargeText);
			base.Controls.Add(this.labelLargeKey);
			base.Controls.Add(this.labelState);
			base.Controls.Add(this.labelDetails);
			base.Controls.Add(this.labelID);
			base.Controls.Add(this.buttonDisconnect);
			base.Controls.Add(this.buttonConnect);
			base.Controls.Add(this.buttonUpdatePresence);
			base.Controls.Add(this.textBoxLargeText);
			base.Controls.Add(this.comboBoxLargeKey);
			base.Controls.Add(this.textBoxState);
			base.Controls.Add(this.textBoxDetails);
			base.Controls.Add(this.textBoxID);
			base.Controls.Add(this.menuStrip);
			this.ForeColor = global::System.Drawing.Color.White;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = global::CustomRPC.Properties.Resources.favicon;
			base.MainMenuStrip = this.menuStrip;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "MainForm";
			this.toolTipInfo.SetToolTip(this, componentResourceManager.GetString("$this.ToolTip"));
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.MinimizeToTray);
			base.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.DragDropHandler);
			base.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.DragDropEnter);
			this.trayMenuStrip.ResumeLayout(false);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.panelTimestamps.ResumeLayout(false);
			this.panelTimestamps.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDownPartySize).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDownPartyMax).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000039 RID: 57
		private global::DiscordRPC.DiscordRpcClient client;

		// Token: 0x0400004C RID: 76
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.NotifyIcon trayIcon;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.ContextMenuStrip trayMenuStrip;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.ToolStripMenuItem trayMenuReconnect;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.ToolStripMenuItem trayMenuQuit;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.MenuStrip menuStrip;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.ToolStripMenuItem runOnStartupToolStripMenuItem;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.ToolStripMenuItem startMinimizedToolStripMenuItem;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.TextBox textBoxID;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.TextBox textBoxDetails;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.TextBox textBoxState;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.ComboBox comboBoxSmallKey;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.TextBox textBoxSmallText;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.ComboBox comboBoxLargeKey;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.TextBox textBoxLargeText;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.Button buttonUpdatePresence;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.Button buttonConnect;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.Button buttonDisconnect;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.Label labelID;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.Label labelDetails;

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Forms.Label labelState;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.Label labelSmallKey;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.Label labelSmallText;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.Label labelLargeText;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.Label labelLargeKey;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.Label labelSmall;

		// Token: 0x0400006A RID: 106
		private global::System.Windows.Forms.Label labelLarge;

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparatorTray1;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.ToolTip toolTipInfo;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.ToolStripMenuItem uploadAssetsToolStripMenuItem;

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparatorFile1;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.RadioButton radioButtonLocalTime;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Forms.RadioButton radioButtonStartTime;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.RadioButton radioButtonNone;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.Panel panelTimestamps;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.Label labelTimestamp;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.ToolStripMenuItem downloadUpdateToolStripMenuItem;

		// Token: 0x04000075 RID: 117
		private global::System.Windows.Forms.ToolStripMenuItem gitHubPageToolStripMenuItem;

		// Token: 0x04000076 RID: 118
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparatorHelp1;

		// Token: 0x04000077 RID: 119
		private global::System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

		// Token: 0x04000078 RID: 120
		private global::System.Windows.Forms.ToolStripMenuItem openTheManualToolStripMenuItem;

		// Token: 0x04000079 RID: 121
		private global::System.Windows.Forms.ToolStripMenuItem checkUpdatesToolStripMenuItem;

		// Token: 0x0400007A RID: 122
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparatorSettings1;

		// Token: 0x0400007B RID: 123
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparatorHelp2;

		// Token: 0x0400007C RID: 124
		private global::System.Windows.Forms.ToolStripMenuItem translatorsToolStripMenuItem;

		// Token: 0x0400007D RID: 125
		private global::System.Windows.Forms.ToolStripMenuItem loadPresetToolStripMenuItem;

		// Token: 0x0400007E RID: 126
		private global::System.Windows.Forms.ToolStripMenuItem savePresetToolStripMenuItem;

		// Token: 0x0400007F RID: 127
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparatorFile2;

		// Token: 0x04000080 RID: 128
		private global::System.Windows.Forms.Label labelParty;

		// Token: 0x04000081 RID: 129
		private global::System.Windows.Forms.Label labelPartyOf;

		// Token: 0x04000082 RID: 130
		private global::System.Windows.Forms.NumericUpDown numericUpDownPartyMax;

		// Token: 0x04000083 RID: 131
		private global::System.Windows.Forms.NumericUpDown numericUpDownPartySize;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.Forms.StatusStrip statusStrip;

		// Token: 0x04000085 RID: 133
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPadding;

		// Token: 0x04000086 RID: 134
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;

		// Token: 0x04000087 RID: 135
		private global::System.Windows.Forms.DateTimePicker dateTimePickerTimestamp;

		// Token: 0x04000088 RID: 136
		private global::System.Windows.Forms.RadioButton radioButtonCustom;

		// Token: 0x04000089 RID: 137
		private global::System.Windows.Forms.TextBox textBoxButton2Text;

		// Token: 0x0400008A RID: 138
		private global::System.Windows.Forms.TextBox textBoxButton2URL;

		// Token: 0x0400008B RID: 139
		private global::System.Windows.Forms.Label labelButton1;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.Label labelButton2;

		// Token: 0x0400008D RID: 141
		private global::System.Windows.Forms.Label labelButton1URL;

		// Token: 0x0400008E RID: 142
		private global::System.Windows.Forms.TextBox textBoxButton1URL;

		// Token: 0x0400008F RID: 143
		private global::System.Windows.Forms.TextBox textBoxButton1Text;

		// Token: 0x04000090 RID: 144
		private global::System.Windows.Forms.Label labelButton2URL;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.Label labelButton1Text;

		// Token: 0x04000092 RID: 146
		private global::System.Windows.Forms.Label labelButton2Text;

		// Token: 0x04000093 RID: 147
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparatorSettings2;

		// Token: 0x04000094 RID: 148
		private global::System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;

		// Token: 0x04000095 RID: 149
		private global::System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;

		// Token: 0x04000096 RID: 150
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x04000097 RID: 151
		private global::System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;

		// Token: 0x04000098 RID: 152
		private global::System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;

		// Token: 0x04000099 RID: 153
		private global::System.Windows.Forms.ToolStripMenuItem autoconnectToolStripMenuItem;

		// Token: 0x0400009A RID: 154
		private global::System.Windows.Forms.ToolStripMenuItem trayMenuDisconnect;

		// Token: 0x0400009B RID: 155
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		// Token: 0x0400009C RID: 156
		private global::System.Windows.Forms.ToolStripMenuItem allowAnalyticsToolStripMenuItem;

		// Token: 0x0400009D RID: 157
		private global::System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;

		// Token: 0x0400009E RID: 158
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparatorSettings3;

		// Token: 0x0400009F RID: 159
		private global::System.Windows.Forms.ToolStripMenuItem sampleLanguageToolStripMenuItem;

		// Token: 0x040000A0 RID: 160
		private global::System.Windows.Forms.ToolStripMenuItem samplePersonToolStripMenuItem;

		// Token: 0x040000A1 RID: 161
		private global::System.Windows.Forms.ToolStripMenuItem sampleToolStripMenuItem;

		// Token: 0x040000A2 RID: 162
		private global::System.Windows.Forms.ToolStripMenuItem supportersToolStripMenuItem;

		// Token: 0x040000A3 RID: 163
		private global::System.Windows.Forms.ToolStripMenuItem testSupporterToolStripMenuItem;

		// Token: 0x040000A4 RID: 164
		private global::System.Windows.Forms.RadioButton radioButtonPresence;
	}
}
