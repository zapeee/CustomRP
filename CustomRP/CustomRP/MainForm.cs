using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq.Expressions;
using System.Media;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Serialization;
using CustomRPC.Properties;
using DiscordRPC;
using DiscordRPC.Helper;
using DiscordRPC.Message;
using IWshRuntimeLibrary;
using Microsoft.AppCenter.Analytics;
using Microsoft.CSharp.RuntimeBinder;
using Octokit;

namespace CustomRPC
{
	// Token: 0x0200000E RID: 14
	public partial class MainForm : Form
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00003048 File Offset: 0x00001248
		public MainForm(string preset)
		{
			this.InitializeComponent();
			Utils.LanguagesSetup(this.translatorsToolStripMenuItem, new EventHandler(this.OpenPersonsPage), this.languageToolStripMenuItem, new EventHandler(this.ChangeLanguage));
			Utils.SupportersSetup(this.supportersToolStripMenuItem, new EventHandler(this.OpenPersonsPage));
			this.ThemeSetup();
			this.StartupSetup();
			this.restartTimer.AutoReset = false;
			this.restartTimer.Elapsed += this.RestartTimer_Elapsed;
			if (preset != null)
			{
				this.LoadPreset(preset);
			}
			this.runOnStartupToolStripMenuItem.Checked = this.settings.runOnStartup;
			this.startMinimizedToolStripMenuItem.Checked = this.settings.startMinimized;
			this.autoconnectToolStripMenuItem.Checked = this.settings.autoconnect;
			this.checkUpdatesToolStripMenuItem.Checked = this.settings.checkUpdates;
			this.allowAnalyticsToolStripMenuItem.Checked = Analytics.IsEnabledAsync().Result;
			this.darkModeToolStripMenuItem.Checked = this.settings.darkMode;
			foreach (object obj in this.languageToolStripMenuItem.DropDownItems)
			{
				if (!(obj is ToolStripSeparator))
				{
					ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)obj;
					if ((string)toolStripMenuItem.Tag == this.settings.language)
					{
						toolStripMenuItem.Checked = true;
						break;
					}
				}
			}
			this.radioButtonNone.Tag = TimestampType.None;
			this.radioButtonStartTime.Tag = TimestampType.SinceStartup;
			this.radioButtonPresence.Tag = TimestampType.SincePresenceUpdate;
			this.radioButtonLocalTime.Tag = TimestampType.LocalTime;
			this.radioButtonCustom.Tag = TimestampType.Custom;
			switch (this.settings.timestamps)
			{
			case 0:
				this.radioButtonNone.Checked = true;
				break;
			case 1:
				this.radioButtonStartTime.Checked = true;
				break;
			case 2:
				this.radioButtonLocalTime.Checked = true;
				break;
			case 3:
				this.radioButtonCustom.Checked = true;
				break;
			case 4:
				this.radioButtonPresence.Checked = true;
				break;
			}
			this.dateTimePickerTimestamp.Enabled = this.radioButtonCustom.Checked;
			this.dateTimePickerTimestamp.CustomFormat = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern + " " + CultureInfo.CurrentCulture.DateTimeFormat.LongTimePattern;
			if (this.settings.customTimestamp.CompareTo(new DateTime(1969, 1, 1, 0, 0, 0)) == 0)
			{
				this.settings.customTimestamp = DateTime.Now;
			}
			this.dateTimePickerTimestamp.MinDate = new DateTime(2001, 9, 9, 1, 46, 40, DateTimeKind.Utc).ToLocalTime();
			this.toolTipInfo.ToolTipTitle = Strings.information;
			this.trayMenuDisconnect.Text = this.res.GetString("buttonDisconnect.Text");
			if (this.settings.language == "bg")
			{
				this.trayMenuDisconnect.Text = "Прекъсни връзката";
			}
			this.toolStripStatusLabelStatus.Text = Strings.statusDisconnected;
			if (Program.IsSecondInstance)
			{
				NotifyIcon notifyIcon = this.trayIcon;
				notifyIcon.Text += " 2";
				this.Text += " 2";
			}
			string text = this.translatedWikiLocales.FindLast(new Predicate<string>(MainForm.<.ctor>g__localePredicate|19_0));
			if (text != null && text != "")
			{
				this.localeUrl = "v/" + text + "/";
			}
			this.loading = false;
			if (this.settings.changedLanguage || !this.settings.startMinimized)
			{
				base.Show();
			}
			if (this.settings.id != "" && this.settings.firstStart)
			{
				this.settings.firstStart = false;
				Utils.SaveSettings();
			}
			if (this.settings.firstStart)
			{
				if (MessageBox.Show(this, Strings.firstTimeRunText, Strings.firstTimeRun, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
				{
					Process.Start("https://docs.customrp.xyz/" + this.localeUrl + "setting-up");
				}
				this.settings.firstStart = false;
				Utils.SaveSettings();
			}
			if (this.settings.id != "" && ((this.settings.changedLanguage && this.settings.wasConnected) || (this.settings.autoconnect && !this.settings.changedLanguage)))
			{
				this.Connect();
			}
			this.CheckIfCrashed();
			if (this.settings.checkUpdates)
			{
				this.CheckForUpdates(false);
			}
			this.settings.changedLanguage = false;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003674 File Offset: 0x00001874
		protected override void WndProc(ref Message message)
		{
			if (message.Msg == Program.WM_SHOWFIRSTINSTANCE)
			{
				this.MaximizeFromTray();
			}
			else if (message.Msg == Program.WM_IMPORTPRESET)
			{
				this.LoadPreset(Path.GetTempPath() + "preset.crp");
			}
			base.WndProc(ref message);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000036B4 File Offset: 0x000018B4
		private void ThemeSetup()
		{
			if (WinApi.UseImmersiveDarkMode(base.Handle))
			{
				base.Opacity = 0.99;
				base.Opacity = 1.0;
			}
			CurrentColors.Update();
			this.BackColor = CurrentColors.BgColor;
			this.ForeColor = CurrentColors.TextColor;
			foreach (object obj in base.Controls)
			{
				if (obj is TextBox || obj is ComboBox || obj is NumericUpDown)
				{
					if (MainForm.<>o__21.<>p__0 == null)
					{
						MainForm.<>o__21.<>p__0 = CallSite<Func<CallSite, object, Color, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "BackColor", typeof(MainForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					MainForm.<>o__21.<>p__0.Target(MainForm.<>o__21.<>p__0, obj, CurrentColors.BgTextFields);
					if (MainForm.<>o__21.<>p__1 == null)
					{
						MainForm.<>o__21.<>p__1 = CallSite<Func<CallSite, object, Color, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "ForeColor", typeof(MainForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					MainForm.<>o__21.<>p__1.Target(MainForm.<>o__21.<>p__1, obj, CurrentColors.TextColor);
				}
			}
			switch (ConnectionManager.State)
			{
			case ConnectionType.Disconnected:
			case ConnectionType.Connecting:
				this.textBoxID.BackColor = CurrentColors.BgTextFields;
				break;
			case ConnectionType.Connected:
				this.textBoxID.BackColor = CurrentColors.BgTextFieldsSuccess;
				break;
			case ConnectionType.Error:
				this.textBoxID.BackColor = CurrentColors.BgTextFieldsError;
				break;
			}
			if (this.settings.darkMode)
			{
				ToolStripManager.Renderer = new DarkModeRenderer();
				this.buttonConnect.FlatStyle = (this.buttonDisconnect.FlatStyle = (this.buttonUpdatePresence.FlatStyle = FlatStyle.Flat));
				return;
			}
			ToolStripManager.Renderer = new LightModeRenderer();
			this.buttonConnect.FlatStyle = (this.buttonDisconnect.FlatStyle = (this.buttonUpdatePresence.FlatStyle = FlatStyle.Standard));
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000038EC File Offset: 0x00001AEC
		private void RestartTimer_Elapsed(object sender, ElapsedEventArgs e)
		{
			if (this.restartAttemptsLeft == 0)
			{
				this.restartAttemptsLeft = -1;
				base.Invoke(new MethodInvoker(delegate()
				{
					this.Disconnect();
				}));
				return;
			}
			if (this.restartAttemptsLeft == -1)
			{
				this.restartAttemptsLeft = this.restartAttempts;
			}
			this.restartAttemptsLeft--;
			base.Invoke(new MethodInvoker(delegate()
			{
				this.Connect();
			}));
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003954 File Offset: 0x00001B54
		private void CheckIfCrashed()
		{
			MainForm.<CheckIfCrashed>d__23 <CheckIfCrashed>d__;
			<CheckIfCrashed>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CheckIfCrashed>d__.<>1__state = -1;
			<CheckIfCrashed>d__.<>t__builder.Start<MainForm.<CheckIfCrashed>d__23>(ref <CheckIfCrashed>d__);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003984 File Offset: 0x00001B84
		private void CheckForUpdates(bool manual = false)
		{
			MainForm.<CheckForUpdates>d__24 <CheckForUpdates>d__;
			<CheckForUpdates>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CheckForUpdates>d__.<>4__this = this;
			<CheckForUpdates>d__.manual = manual;
			<CheckForUpdates>d__.<>1__state = -1;
			<CheckForUpdates>d__.<>t__builder.Start<MainForm.<CheckForUpdates>d__24>(ref <CheckForUpdates>d__);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000039C4 File Offset: 0x00001BC4
		public void DownloadAndInstallUpdate()
		{
			MainForm.<DownloadAndInstallUpdate>d__25 <DownloadAndInstallUpdate>d__;
			<DownloadAndInstallUpdate>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<DownloadAndInstallUpdate>d__.<>4__this = this;
			<DownloadAndInstallUpdate>d__.<>1__state = -1;
			<DownloadAndInstallUpdate>d__.<>t__builder.Start<MainForm.<DownloadAndInstallUpdate>d__25>(ref <DownloadAndInstallUpdate>d__);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000039FC File Offset: 0x00001BFC
		private void DownloadProgress(object sender, DownloadProgressChangedEventArgs e)
		{
			this.downloadUpdateToolStripMenuItem.Text = e.ProgressPercentage.ToString() + "%";
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003A2C File Offset: 0x00001C2C
		private bool Init()
		{
			if (this.settings.id == "")
			{
				MessageBox.Show(Strings.errorNoID, Strings.error, MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
				return false;
			}
			if (this.client != null && !this.client.IsDisposed)
			{
				this.client.Dispose();
			}
			this.client = new DiscordRpcClient(this.settings.id, (int)this.settings.pipe, null, true, null);
			this.client.OnPresenceUpdate += this.ClientOnPresenceUpdate;
			this.client.OnError += this.ClientOnError;
			this.client.OnConnectionFailed += this.ClientOnConnFailed;
			this.client.Logger = new TimestampFileLogger(System.Windows.Forms.Application.StartupPath + "\\rpc.log");
			this.client.Initialize();
			return this.SetPresence();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003B28 File Offset: 0x00001D28
		private void ClientOnPresenceUpdate(object sender, PresenceMessage args)
		{
			RichPresence currentPresence = this.client.CurrentPresence;
			ConnectionManager.State = ConnectionType.Connected;
			base.Invoke(new MethodInvoker(delegate()
			{
				this.textBoxID.BackColor = CurrentColors.BgTextFieldsSuccess;
				this.toolStripStatusLabelStatus.Text = Strings.statusConnected;
			}));
			Analytics.TrackEvent("Updated presence", new Dictionary<string, string>
			{
				{
					"Party",
					currentPresence.HasParty().ToString()
				},
				{
					"Timestamp",
					((TimestampType)this.settings.timestamps).ToString()
				},
				{
					"Big image",
					(currentPresence.Assets.LargeImageID != null).ToString()
				},
				{
					"Small image",
					(currentPresence.Assets.SmallImageID != null).ToString()
				},
				{
					"Buttons",
					this.buttonsList.Count.ToString()
				}
			});
			this.restartTimer.Stop();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003C1C File Offset: 0x00001E1C
		private void ClientOnError(object sender, ErrorMessage args)
		{
			ConnectionManager.State = ConnectionType.Error;
			base.Invoke(new MethodInvoker(delegate()
			{
				if (this.buttonConnect.Enabled)
				{
					return;
				}
				this.textBoxID.BackColor = CurrentColors.BgTextFieldsError;
				this.toolStripStatusLabelStatus.Text = Strings.statusError;
			}));
			if (ConnectionManager.HasChanged())
			{
				Analytics.TrackEvent("Connection error", null);
			}
			this.restartTimer.Start();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003C54 File Offset: 0x00001E54
		private void ClientOnConnFailed(object sender, ConnectionFailedMessage args)
		{
			ConnectionManager.State = ConnectionType.Error;
			base.Invoke(new MethodInvoker(delegate()
			{
				if (this.buttonConnect.Enabled)
				{
					return;
				}
				this.textBoxID.BackColor = CurrentColors.BgTextFieldsError;
				this.toolStripStatusLabelStatus.Text = Strings.statusConnectionFailed;
			}));
			if (ConnectionManager.HasChanged())
			{
				Analytics.TrackEvent("Connection failed", null);
			}
			this.restartTimer.Start();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003C8C File Offset: 0x00001E8C
		private bool SetPresence()
		{
			if (this.client == null || this.client.IsDisposed)
			{
				return false;
			}
			foreach (TextBox textBox in new TextBox[]
			{
				this.textBoxDetails,
				this.textBoxState
			})
			{
				if (textBox.Text.StartsWith(this.U00A0) && textBox.Text.WithinLength(textBox.MaxLength - 3))
				{
					textBox.Text = textBox.Text.Insert(0, this.U200B);
				}
				else if (textBox.Text.StartsWith(this.U00A0 + this.U00A0) && textBox.Text.WithinLength(textBox.MaxLength - 1))
				{
					textBox.Text = this.U200B + textBox.Text.Substring(1);
				}
				else if (textBox.Text.StartsWith(this.U00A0 + this.U00A0 + this.U00A0))
				{
					textBox.Text = this.U200B + textBox.Text.Substring(2);
				}
			}
			if (this.settings.partySize > this.settings.partyMax)
			{
				this.numericUpDownPartyMax.Value = this.settings.partySize;
			}
			this.settings.smallKey = this.settings.smallKey.Trim();
			this.settings.largeKey = this.settings.largeKey.Trim();
			this.settings.button1URL = this.settings.button1URL.Trim();
			this.settings.button2URL = this.settings.button2URL.Trim();
			RichPresence richPresence = new RichPresence
			{
				Details = this.settings.details,
				State = this.settings.state,
				Party = new Party
				{
					ID = ((this.settings.partySize > 0m && this.settings.partyMax > 0m) ? "CustomRP" : ""),
					Size = (int)this.settings.partySize,
					Max = (int)this.settings.partyMax
				}
			};
			try
			{
				Uri uri;
				if (Uri.TryCreate(this.settings.smallKey, UriKind.Absolute, out uri))
				{
					this.settings.smallKey = uri.AbsoluteUri;
				}
				if (Uri.TryCreate(this.settings.largeKey, UriKind.Absolute, out uri))
				{
					this.settings.largeKey = uri.AbsoluteUri;
				}
				richPresence.Assets = new Assets
				{
					SmallImageKey = this.settings.smallKey,
					SmallImageText = this.settings.smallText,
					LargeImageKey = this.settings.largeKey,
					LargeImageText = this.settings.largeText
				};
				if (richPresence.Assets.SmallImageKey != null)
				{
					richPresence.Assets.SmallImageKey = Regex.Replace(richPresence.Assets.SmallImageKey, "//((cdn)|(media))\\.discordapp\\.((com)|(net))/", "//customrp.xyz/proxy/");
				}
				if (richPresence.Assets.LargeImageKey != null)
				{
					richPresence.Assets.LargeImageKey = Regex.Replace(richPresence.Assets.LargeImageKey, "//((cdn)|(media))\\.discordapp\\.((com)|(net))/", "//customrp.xyz/proxy/");
				}
			}
			catch
			{
				MessageBox.Show(Strings.errorInvalidImageURL, Strings.error, MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
				return false;
			}
			finally
			{
				Utils.SaveSettings();
			}
			this.buttonsList.Clear();
			try
			{
				Uri uri;
				if (Uri.TryCreate(this.settings.button1URL, UriKind.Absolute, out uri))
				{
					this.settings.button1URL = uri.AbsoluteUri;
				}
				if (Uri.TryCreate(this.settings.button2URL, UriKind.Absolute, out uri))
				{
					this.settings.button2URL = uri.AbsoluteUri;
				}
				Utils.SaveSettings();
				if (this.settings.button1Text != "" && this.settings.button1URL != "")
				{
					this.buttonsList.Add(new DiscordRPC.Button
					{
						Label = this.settings.button1Text,
						Url = this.settings.button1URL
					});
				}
				if (this.settings.button2Text != "" && this.settings.button2URL != "")
				{
					this.buttonsList.Add(new DiscordRPC.Button
					{
						Label = this.settings.button2Text,
						Url = this.settings.button2URL
					});
				}
			}
			catch
			{
				MessageBox.Show(Strings.errorInvalidURL, Strings.error, MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
				return false;
			}
			finally
			{
				Utils.SaveSettings();
			}
			richPresence.Buttons = this.buttonsList.ToArray();
			switch (this.settings.timestamps)
			{
			case 1:
				richPresence.Timestamps = new Timestamps(this.timestampStarted);
				break;
			case 2:
				richPresence.Timestamps = new Timestamps(DateTime.UtcNow.Subtract(new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second)));
				break;
			case 3:
			{
				DateTime dateTime = this.dateTimePickerTimestamp.Value.ToUniversalTime();
				richPresence.Timestamps = ((dateTime.CompareTo(DateTime.UtcNow) < 0) ? new Timestamps(dateTime) : new Timestamps(DateTime.UtcNow, dateTime));
				break;
			}
			case 4:
				richPresence.Timestamps = new Timestamps(DateTime.UtcNow);
				break;
			}
			this.client.SetPresence(richPresence);
			return true;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000042D4 File Offset: 0x000024D4
		private void StartupSetup()
		{
			try
			{
				if (this.settings.runOnStartup && !File.Exists(this.linkPath))
				{
					IWshShortcut wshShortcut = ((WshShell)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")))).CreateShortcut(this.linkPath) as IWshShortcut;
					wshShortcut.Description = "Discord Custom Rich Presence Manager";
					wshShortcut.TargetPath = Environment.CurrentDirectory + "\\CustomRP.exe";
					wshShortcut.WorkingDirectory = Environment.CurrentDirectory + "\\";
					if (Program.IsSecondInstance)
					{
						wshShortcut.Arguments = "--second-instance";
					}
					wshShortcut.Save();
				}
				else if (!this.settings.runOnStartup && File.Exists(this.linkPath))
				{
					File.Delete(this.linkPath);
				}
			}
			catch (Exception ex)
			{
				this.runOnStartupToolStripMenuItem.Checked = !this.settings.runOnStartup;
				MessageBox.Show(Strings.errorStartupShortcut + " " + ex.Message, Strings.error, MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000043F0 File Offset: 0x000025F0
		private void DragDropEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.All;
				return;
			}
			e.Effect = DragDropEffects.None;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00004418 File Offset: 0x00002618
		private void DragDropHandler(object sender, DragEventArgs e)
		{
			string[] array = e.Data.GetData(DataFormats.FileDrop) as string[];
			if (array != null && array.Length != 0)
			{
				this.LoadPreset(array[0]);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000444C File Offset: 0x0000264C
		private void MinimizeToTray(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				base.Hide();
				if (!this.settings.startMinimized && !this.settings.wasTooltipShown)
				{
					this.trayIcon.ShowBalloonTip(500);
					this.settings.wasTooltipShown = true;
				}
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000044A5 File Offset: 0x000026A5
		private void MaximizeFromTray(object sender, EventArgs e)
		{
			this.MaximizeFromTray();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000044B0 File Offset: 0x000026B0
		private void MaximizeFromTray()
		{
			switch (ConnectionManager.State)
			{
			case ConnectionType.Disconnected:
				this.textBoxID.BackColor = CurrentColors.BgTextFields;
				this.toolStripStatusLabelStatus.Text = Strings.statusDisconnected;
				break;
			case ConnectionType.Connecting:
				this.textBoxID.BackColor = CurrentColors.BgTextFields;
				this.toolStripStatusLabelStatus.Text = Strings.statusConnecting;
				break;
			case ConnectionType.Connected:
				this.textBoxID.BackColor = CurrentColors.BgTextFieldsSuccess;
				this.toolStripStatusLabelStatus.Text = Strings.statusConnected;
				break;
			case ConnectionType.Error:
				this.textBoxID.BackColor = CurrentColors.BgTextFieldsError;
				this.toolStripStatusLabelStatus.Text = Strings.statusError;
				break;
			}
			base.Show();
			base.Activate();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00004570 File Offset: 0x00002770
		private void LoadPreset(Stream file)
		{
			try
			{
				Preset preset = (Preset)new XmlSerializer(typeof(Preset)).Deserialize(file);
				bool enabled = this.buttonDisconnect.Enabled;
				bool flag = this.settings.id != preset.ID;
				this.settings.id = preset.ID;
				this.settings.details = preset.Details;
				this.settings.state = preset.State;
				this.settings.partySize = preset.PartySize;
				this.settings.partyMax = preset.PartyMax;
				this.settings.timestamps = preset.Timestamps;
				this.settings.customTimestamp = preset.CustomTimestamp;
				this.settings.largeKey = preset.LargeKey;
				this.settings.largeText = preset.LargeText;
				this.settings.smallKey = preset.SmallKey;
				this.settings.smallText = preset.SmallText;
				this.settings.button1Text = preset.Button1Text;
				this.settings.button1URL = preset.Button1URL;
				this.settings.button2Text = preset.Button2Text;
				this.settings.button2URL = preset.Button2URL;
				Utils.SaveSettings();
				switch (this.settings.timestamps)
				{
				case 0:
					this.radioButtonNone.Checked = true;
					break;
				case 1:
					this.radioButtonStartTime.Checked = true;
					break;
				case 2:
					this.radioButtonLocalTime.Checked = true;
					break;
				case 3:
					this.radioButtonCustom.Checked = true;
					break;
				case 4:
					this.radioButtonPresence.Checked = true;
					break;
				}
				Analytics.TrackEvent("Loaded a preset", null);
				if (!enabled)
				{
					return;
				}
				if (flag || ConnectionManager.State != ConnectionType.Connected)
				{
					this.Reconnect();
				}
				else
				{
					this.SetPresence();
				}
			}
			catch
			{
				MessageBox.Show(Strings.errorInvalidPresetFile, Strings.error, MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			file.Close();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000479C File Offset: 0x0000299C
		private void LoadPreset(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "CustomRP Preset|*.crp"
			};
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			try
			{
				this.LoadPreset(openFileDialog.OpenFile());
			}
			catch
			{
				MessageBox.Show(Strings.errorInvalidPresetFile, Strings.error, MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000047FC File Offset: 0x000029FC
		private void LoadPreset(string filePath)
		{
			try
			{
				this.LoadPreset(File.OpenRead(filePath));
			}
			catch
			{
				MessageBox.Show(Strings.errorInvalidPresetFile, Strings.error, MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00004840 File Offset: 0x00002A40
		private void SavePreset(object sender, EventArgs e)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(Preset));
			SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				Filter = "CustomRP Preset|*.crp"
			};
			if (saveFileDialog.ShowDialog() != DialogResult.OK || saveFileDialog.FileNames.Length == 0)
			{
				return;
			}
			for (;;)
			{
				try
				{
					using (Stream stream = saveFileDialog.OpenFile())
					{
						xmlSerializer.Serialize(stream, new Preset
						{
							ID = this.settings.id,
							Details = this.settings.details,
							State = this.settings.state,
							PartySize = (int)this.settings.partySize,
							PartyMax = (int)this.settings.partyMax,
							Timestamps = this.settings.timestamps,
							CustomTimestamp = this.settings.customTimestamp,
							LargeKey = this.settings.largeKey,
							LargeText = this.settings.largeText,
							SmallKey = this.settings.smallKey,
							SmallText = this.settings.smallText,
							Button1Text = this.settings.button1Text,
							Button1URL = this.settings.button1URL,
							Button2Text = this.settings.button2Text,
							Button2URL = this.settings.button2URL
						});
					}
					Analytics.TrackEvent("Saved a preset", null);
				}
				catch (IOException ex)
				{
					if (MessageBox.Show(ex.Message, Strings.error, MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand) != DialogResult.Cancel)
					{
						continue;
					}
				}
				break;
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00004A20 File Offset: 0x00002C20
		private void OpenDiscordSite(object sender, EventArgs e)
		{
			if (this.settings.id == "")
			{
				MessageBox.Show(Strings.errorNoID, Strings.error, MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
				return;
			}
			Process.Start("https://discord.com/developers/applications/" + this.settings.id + "/rich-presence/assets");
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00004A79 File Offset: 0x00002C79
		private void Quit(object sender, EventArgs e)
		{
			if (this.client != null)
			{
				this.client.Dispose();
			}
			if (Utils.SaveSettings())
			{
				System.Windows.Forms.Application.Exit();
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00004A9C File Offset: 0x00002C9C
		private void SaveMenuSettings(object sender, EventArgs e)
		{
			if (this.loading)
			{
				return;
			}
			ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
			string text = toolStripMenuItem.Name.Replace("ToolStripMenuItem", "");
			if (!(text == "runOnStartup"))
			{
				if (!(text == "startMinimized"))
				{
					if (!(text == "autoconnect"))
					{
						if (!(text == "checkUpdates"))
						{
							if (!(text == "allowAnalytics"))
							{
								if (!(text == "darkMode"))
								{
									throw new NotImplementedException(text);
								}
								this.settings.darkMode = toolStripMenuItem.Checked;
								this.ThemeSetup();
							}
							else
							{
								this.settings.analytics = toolStripMenuItem.Checked;
								Analytics.SetEnabledAsync(toolStripMenuItem.Checked);
							}
						}
						else
						{
							this.settings.checkUpdates = toolStripMenuItem.Checked;
							if (toolStripMenuItem.Checked)
							{
								this.CheckForUpdates(false);
							}
						}
					}
					else
					{
						this.settings.autoconnect = toolStripMenuItem.Checked;
					}
				}
				else
				{
					this.settings.startMinimized = toolStripMenuItem.Checked;
				}
			}
			else
			{
				this.settings.runOnStartup = toolStripMenuItem.Checked;
				this.StartupSetup();
			}
			Utils.SaveSettings();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00004BD0 File Offset: 0x00002DD0
		private void ChangeLanguage(object sender, EventArgs e)
		{
			ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
			this.settings.language = (string)toolStripMenuItem.Tag;
			this.settings.changedLanguage = true;
			this.settings.wasConnected = this.buttonDisconnect.Enabled;
			Utils.SaveSettings();
			Program.AppMutex.Close();
			System.Windows.Forms.Application.Restart();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004C31 File Offset: 0x00002E31
		private void OpenSite(object sender, EventArgs e)
		{
			Process.Start(((string)((ToolStripMenuItem)sender).Tag).Replace("docs.customrp.xyz/", "docs.customrp.xyz/" + this.localeUrl));
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00004C64 File Offset: 0x00002E64
		private void OpenPersonsPage(object sender, EventArgs e)
		{
			ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
			if (toolStripMenuItem.Tag == null)
			{
				return;
			}
			ValueTuple<string, string> valueTuple = (ValueTuple<string, string>)toolStripMenuItem.Tag;
			string item = valueTuple.Item1;
			string item2 = valueTuple.Item2;
			if (string.IsNullOrWhiteSpace(item2))
			{
				return;
			}
			string text = toolStripMenuItem.Text;
			if (item == "supporter")
			{
				text = text.Replace(" - ", "|").Split(new char[]
				{
					'|'
				})[0];
			}
			Analytics.TrackEvent("Clicked on a " + item, new Dictionary<string, string>
			{
				{
					"Name",
					text
				},
				{
					"URL",
					item2
				}
			});
			Process.Start(item2);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00004D0D File Offset: 0x00002F0D
		private void CheckForUpdates(object sender, EventArgs e)
		{
			this.CheckForUpdates(true);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00004D16 File Offset: 0x00002F16
		private void ShowAbout(object sender, EventArgs e)
		{
			Analytics.TrackEvent("Opened about window", null);
			new About().ShowDialog(this);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004D2F File Offset: 0x00002F2F
		private void DownloadUpdate(object sender, EventArgs e)
		{
			this.downloadUpdateToolStripMenuItem.Enabled = false;
			this.DownloadAndInstallUpdate();
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00004D44 File Offset: 0x00002F44
		private void OnlyNumbers(object sender, EventArgs e)
		{
			if (this.toAvoidRecursion || this.textBoxID.Text == "")
			{
				return;
			}
			this.textBoxID.ReadOnly = true;
			this.toAvoidRecursion = true;
			int selectionStart = this.textBoxID.SelectionStart;
			int num = 0;
			string text = "";
			foreach (char c in this.textBoxID.Text)
			{
				if (char.IsDigit(c))
				{
					text += c.ToString();
				}
				else
				{
					num++;
				}
			}
			if (num > 0)
			{
				this.textBoxID.Text = text;
				this.textBoxID.SelectionStart = selectionStart - num;
				this.textBoxID.SelectionLength = 0;
			}
			this.textBoxID.ReadOnly = false;
			this.toAvoidRecursion = false;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00004E1D File Offset: 0x0000301D
		private void Connect(object sender, EventArgs e)
		{
			if (Control.ModifierKeys == (Keys.Shift | Keys.Control) && sender is System.Windows.Forms.Button)
			{
				Analytics.TrackEvent("Opened pipe selector window", null);
				new PipeSelector().ShowDialog(this);
				return;
			}
			this.Connect();
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00004E54 File Offset: 0x00003054
		private void Connect()
		{
			Utils.SaveSettings();
			if (this.Init())
			{
				if (ConnectionManager.State == ConnectionType.Disconnected)
				{
					Analytics.TrackEvent("Connected", null);
				}
				ConnectionManager.State = ConnectionType.Connecting;
				this.buttonConnect.Enabled = false;
				this.buttonDisconnect.Enabled = true;
				this.trayMenuDisconnect.Enabled = true;
				this.textBoxID.ReadOnly = true;
				this.buttonUpdatePresence.Enabled = true;
				this.toolStripStatusLabelStatus.Text = Strings.statusConnecting;
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00004ED3 File Offset: 0x000030D3
		private void Disconnect(object sender, EventArgs e)
		{
			this.Disconnect();
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004EDC File Offset: 0x000030DC
		private void Disconnect()
		{
			this.buttonConnect.Enabled = true;
			this.buttonDisconnect.Enabled = false;
			this.trayMenuDisconnect.Enabled = false;
			this.buttonUpdatePresence.Enabled = false;
			this.textBoxID.ReadOnly = false;
			this.toolStripStatusLabelStatus.Text = Strings.statusDisconnected;
			this.textBoxID.BackColor = CurrentColors.BgTextFields;
			ConnectionManager.State = ConnectionType.Disconnected;
			this.restartTimer.Stop();
			this.client.Dispose();
			Analytics.TrackEvent("Disconnected", null);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00004F6C File Offset: 0x0000316C
		private void Reconnect()
		{
			this.restartTimer.Stop();
			this.client.Dispose();
			this.textBoxID.BackColor = CurrentColors.BgTextFields;
			Utils.SaveSettings();
			if (this.Init())
			{
				ConnectionManager.State = ConnectionType.Connecting;
				this.toolStripStatusLabelStatus.Text = Strings.statusConnecting;
				return;
			}
			this.Disconnect();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00004FCC File Offset: 0x000031CC
		private void LengthValidationFocus(object sender, CancelEventArgs e)
		{
			if (MainForm.<>o__57.<>p__6 == null)
			{
				MainForm.<>o__57.<>p__6 = CallSite<Func<CallSite, object, bool>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(bool), typeof(MainForm)));
			}
			Func<CallSite, object, bool> target = MainForm.<>o__57.<>p__6.Target;
			CallSite <>p__ = MainForm.<>o__57.<>p__6;
			if (MainForm.<>o__57.<>p__1 == null)
			{
				MainForm.<>o__57.<>p__1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "EndsWith", null, typeof(MainForm), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target2 = MainForm.<>o__57.<>p__1.Target;
			CallSite <>p__2 = MainForm.<>o__57.<>p__1;
			if (MainForm.<>o__57.<>p__0 == null)
			{
				MainForm.<>o__57.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Name", typeof(MainForm), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			object obj = target2(<>p__2, MainForm.<>o__57.<>p__0.Target(MainForm.<>o__57.<>p__0, sender), "Button1Text");
			if (MainForm.<>o__57.<>p__5 == null)
			{
				MainForm.<>o__57.<>p__5 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(MainForm), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			object arg2;
			if (!MainForm.<>o__57.<>p__5.Target(MainForm.<>o__57.<>p__5, obj))
			{
				if (MainForm.<>o__57.<>p__4 == null)
				{
					MainForm.<>o__57.<>p__4 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.BinaryOperationLogical, ExpressionType.Or, typeof(MainForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object, object> target3 = MainForm.<>o__57.<>p__4.Target;
				CallSite <>p__3 = MainForm.<>o__57.<>p__4;
				object arg = obj;
				if (MainForm.<>o__57.<>p__3 == null)
				{
					MainForm.<>o__57.<>p__3 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "EndsWith", null, typeof(MainForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target4 = MainForm.<>o__57.<>p__3.Target;
				CallSite <>p__4 = MainForm.<>o__57.<>p__3;
				if (MainForm.<>o__57.<>p__2 == null)
				{
					MainForm.<>o__57.<>p__2 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Name", typeof(MainForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				arg2 = target3(<>p__3, arg, target4(<>p__4, MainForm.<>o__57.<>p__2.Target(MainForm.<>o__57.<>p__2, sender), "Button2Text"));
			}
			else
			{
				arg2 = obj;
			}
			bool flag = target(<>p__, arg2);
			if (MainForm.<>o__57.<>p__9 == null)
			{
				MainForm.<>o__57.<>p__9 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(MainForm), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target5 = MainForm.<>o__57.<>p__9.Target;
			CallSite <>p__5 = MainForm.<>o__57.<>p__9;
			if (MainForm.<>o__57.<>p__8 == null)
			{
				MainForm.<>o__57.<>p__8 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Length", typeof(MainForm), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, object> target6 = MainForm.<>o__57.<>p__8.Target;
			CallSite <>p__6 = MainForm.<>o__57.<>p__8;
			if (MainForm.<>o__57.<>p__7 == null)
			{
				MainForm.<>o__57.<>p__7 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Text", typeof(MainForm), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			obj = target5(<>p__5, target6(<>p__6, MainForm.<>o__57.<>p__7.Target(MainForm.<>o__57.<>p__7, sender)), 1);
			if (MainForm.<>o__57.<>p__17 == null)
			{
				MainForm.<>o__57.<>p__17 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(MainForm), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (!MainForm.<>o__57.<>p__17.Target(MainForm.<>o__57.<>p__17, obj))
			{
				if (MainForm.<>o__57.<>p__16 == null)
				{
					MainForm.<>o__57.<>p__16 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(MainForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target7 = MainForm.<>o__57.<>p__16.Target;
				CallSite <>p__7 = MainForm.<>o__57.<>p__16;
				if (MainForm.<>o__57.<>p__15 == null)
				{
					MainForm.<>o__57.<>p__15 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.BinaryOperationLogical, ExpressionType.Or, typeof(MainForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object, object> target8 = MainForm.<>o__57.<>p__15.Target;
				CallSite <>p__8 = MainForm.<>o__57.<>p__15;
				object arg3 = obj;
				object arg6;
				if (flag)
				{
					if (MainForm.<>o__57.<>p__14 == null)
					{
						MainForm.<>o__57.<>p__14 = CallSite<Func<CallSite, bool, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.BinaryOperationLogical, ExpressionType.And, typeof(MainForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, bool, object, object> target9 = MainForm.<>o__57.<>p__14.Target;
					CallSite <>p__9 = MainForm.<>o__57.<>p__14;
					bool arg4 = flag;
					if (MainForm.<>o__57.<>p__13 == null)
					{
						MainForm.<>o__57.<>p__13 = CallSite<Func<CallSite, object, object>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.Not, typeof(MainForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, object> target10 = MainForm.<>o__57.<>p__13.Target;
					CallSite <>p__10 = MainForm.<>o__57.<>p__13;
					if (MainForm.<>o__57.<>p__12 == null)
					{
						MainForm.<>o__57.<>p__12 = CallSite<Func<CallSite, Type, object, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "WithinLength", null, typeof(MainForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, Type, object, object, object> target11 = MainForm.<>o__57.<>p__12.Target;
					CallSite <>p__11 = MainForm.<>o__57.<>p__12;
					Type typeFromHandle = typeof(StringTools);
					if (MainForm.<>o__57.<>p__10 == null)
					{
						MainForm.<>o__57.<>p__10 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Text", typeof(MainForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					object arg5 = MainForm.<>o__57.<>p__10.Target(MainForm.<>o__57.<>p__10, sender);
					if (MainForm.<>o__57.<>p__11 == null)
					{
						MainForm.<>o__57.<>p__11 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "MaxLength", typeof(MainForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					arg6 = target9(<>p__9, arg4, target10(<>p__10, target11(<>p__11, typeFromHandle, arg5, MainForm.<>o__57.<>p__11.Target(MainForm.<>o__57.<>p__11, sender))));
				}
				else
				{
					arg6 = flag;
				}
				if (!target7(<>p__7, target8(<>p__8, arg3, arg6)))
				{
					return;
				}
			}
			e.Cancel = true;
			SystemSounds.Beep.Play();
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00005590 File Offset: 0x00003790
		private void LengthValidation(object sender, EventArgs e)
		{
			if (MainForm.<>o__58.<>p__6 == null)
			{
				MainForm.<>o__58.<>p__6 = CallSite<Func<CallSite, object, bool>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(bool), typeof(MainForm)));
			}
			Func<CallSite, object, bool> target = MainForm.<>o__58.<>p__6.Target;
			CallSite <>p__ = MainForm.<>o__58.<>p__6;
			if (MainForm.<>o__58.<>p__1 == null)
			{
				MainForm.<>o__58.<>p__1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "EndsWith", null, typeof(MainForm), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, string, object> target2 = MainForm.<>o__58.<>p__1.Target;
			CallSite <>p__2 = MainForm.<>o__58.<>p__1;
			if (MainForm.<>o__58.<>p__0 == null)
			{
				MainForm.<>o__58.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Name", typeof(MainForm), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			object obj = target2(<>p__2, MainForm.<>o__58.<>p__0.Target(MainForm.<>o__58.<>p__0, sender), "Button1Text");
			if (MainForm.<>o__58.<>p__5 == null)
			{
				MainForm.<>o__58.<>p__5 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(MainForm), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			object arg2;
			if (!MainForm.<>o__58.<>p__5.Target(MainForm.<>o__58.<>p__5, obj))
			{
				if (MainForm.<>o__58.<>p__4 == null)
				{
					MainForm.<>o__58.<>p__4 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.BinaryOperationLogical, ExpressionType.Or, typeof(MainForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object, object> target3 = MainForm.<>o__58.<>p__4.Target;
				CallSite <>p__3 = MainForm.<>o__58.<>p__4;
				object arg = obj;
				if (MainForm.<>o__58.<>p__3 == null)
				{
					MainForm.<>o__58.<>p__3 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "EndsWith", null, typeof(MainForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, string, object> target4 = MainForm.<>o__58.<>p__3.Target;
				CallSite <>p__4 = MainForm.<>o__58.<>p__3;
				if (MainForm.<>o__58.<>p__2 == null)
				{
					MainForm.<>o__58.<>p__2 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Name", typeof(MainForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				arg2 = target3(<>p__3, arg, target4(<>p__4, MainForm.<>o__58.<>p__2.Target(MainForm.<>o__58.<>p__2, sender), "Button2Text"));
			}
			else
			{
				arg2 = obj;
			}
			bool flag = target(<>p__, arg2);
			if (MainForm.<>o__58.<>p__18 == null)
			{
				MainForm.<>o__58.<>p__18 = CallSite<Func<CallSite, object, Color, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "BackColor", typeof(MainForm), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			Func<CallSite, object, Color, object> target5 = MainForm.<>o__58.<>p__18.Target;
			CallSite <>p__5 = MainForm.<>o__58.<>p__18;
			if (MainForm.<>o__58.<>p__9 == null)
			{
				MainForm.<>o__58.<>p__9 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(MainForm), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target6 = MainForm.<>o__58.<>p__9.Target;
			CallSite <>p__6 = MainForm.<>o__58.<>p__9;
			if (MainForm.<>o__58.<>p__8 == null)
			{
				MainForm.<>o__58.<>p__8 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Length", typeof(MainForm), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, object> target7 = MainForm.<>o__58.<>p__8.Target;
			CallSite <>p__7 = MainForm.<>o__58.<>p__8;
			if (MainForm.<>o__58.<>p__7 == null)
			{
				MainForm.<>o__58.<>p__7 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Text", typeof(MainForm), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			obj = target6(<>p__6, target7(<>p__7, MainForm.<>o__58.<>p__7.Target(MainForm.<>o__58.<>p__7, sender)), 1);
			if (MainForm.<>o__58.<>p__17 == null)
			{
				MainForm.<>o__58.<>p__17 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(MainForm), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Color arg7;
			if (!MainForm.<>o__58.<>p__17.Target(MainForm.<>o__58.<>p__17, obj))
			{
				if (MainForm.<>o__58.<>p__16 == null)
				{
					MainForm.<>o__58.<>p__16 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(MainForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target8 = MainForm.<>o__58.<>p__16.Target;
				CallSite <>p__8 = MainForm.<>o__58.<>p__16;
				if (MainForm.<>o__58.<>p__15 == null)
				{
					MainForm.<>o__58.<>p__15 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.BinaryOperationLogical, ExpressionType.Or, typeof(MainForm), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object, object> target9 = MainForm.<>o__58.<>p__15.Target;
				CallSite <>p__9 = MainForm.<>o__58.<>p__15;
				object arg3 = obj;
				object arg6;
				if (flag)
				{
					if (MainForm.<>o__58.<>p__14 == null)
					{
						MainForm.<>o__58.<>p__14 = CallSite<Func<CallSite, bool, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.BinaryOperationLogical, ExpressionType.And, typeof(MainForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, bool, object, object> target10 = MainForm.<>o__58.<>p__14.Target;
					CallSite <>p__10 = MainForm.<>o__58.<>p__14;
					bool arg4 = flag;
					if (MainForm.<>o__58.<>p__13 == null)
					{
						MainForm.<>o__58.<>p__13 = CallSite<Func<CallSite, object, object>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.Not, typeof(MainForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, object> target11 = MainForm.<>o__58.<>p__13.Target;
					CallSite <>p__11 = MainForm.<>o__58.<>p__13;
					if (MainForm.<>o__58.<>p__12 == null)
					{
						MainForm.<>o__58.<>p__12 = CallSite<Func<CallSite, Type, object, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "WithinLength", null, typeof(MainForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, Type, object, object, object> target12 = MainForm.<>o__58.<>p__12.Target;
					CallSite <>p__12 = MainForm.<>o__58.<>p__12;
					Type typeFromHandle = typeof(StringTools);
					if (MainForm.<>o__58.<>p__10 == null)
					{
						MainForm.<>o__58.<>p__10 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Text", typeof(MainForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					object arg5 = MainForm.<>o__58.<>p__10.Target(MainForm.<>o__58.<>p__10, sender);
					if (MainForm.<>o__58.<>p__11 == null)
					{
						MainForm.<>o__58.<>p__11 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "MaxLength", typeof(MainForm), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					arg6 = target10(<>p__10, arg4, target11(<>p__11, target12(<>p__12, typeFromHandle, arg5, MainForm.<>o__58.<>p__11.Target(MainForm.<>o__58.<>p__11, sender))));
				}
				else
				{
					arg6 = flag;
				}
				if (!target8(<>p__8, target9(<>p__9, arg3, arg6)))
				{
					arg7 = CurrentColors.BgTextFields;
					goto IL_601;
				}
			}
			arg7 = CurrentColors.BgTextFieldsError;
			IL_601:
			target5(<>p__5, sender, arg7);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00005BA4 File Offset: 0x00003DA4
		private void PartySizeValidation(object sender, CancelEventArgs e)
		{
			if (sender == this.numericUpDownPartyMax && this.numericUpDownPartyMax.Value == 0m)
			{
				this.numericUpDownPartySize.Value = 0m;
				return;
			}
			if (this.numericUpDownPartySize.Value > this.numericUpDownPartyMax.Value)
			{
				this.numericUpDownPartyMax.Value = this.numericUpDownPartySize.Value;
				if (sender == this.numericUpDownPartyMax)
				{
					SystemSounds.Beep.Play();
				}
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00005C28 File Offset: 0x00003E28
		private void TimestampsChanged(object sender, EventArgs e)
		{
			if (this.loading)
			{
				return;
			}
			RadioButton radioButton = (RadioButton)sender;
			if (!radioButton.Checked)
			{
				return;
			}
			this.settings.timestamps = (int)radioButton.Tag;
			Utils.SaveSettings();
			this.dateTimePickerTimestamp.Enabled = (this.settings.timestamps == 3);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00005C84 File Offset: 0x00003E84
		private void FetchAssets(object sender, EventArgs e)
		{
			if (this.settings.id == "" || (this.lastIDChecked == this.settings.id && this.nextAssetCheck.CompareTo(DateTime.Now) > 0))
			{
				return;
			}
			this.lastIDChecked = this.settings.id;
			this.comboBoxLargeKey.Items.Clear();
			this.comboBoxSmallKey.Items.Clear();
			using (HttpClient httpClient = new HttpClient())
			{
				httpClient.Timeout = new TimeSpan(0, 0, 15);
				try
				{
					ServicePointManager.Expect100Continue = true;
					ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
					HttpResponseMessage result = httpClient.GetAsync("https://discordapp.com/api/oauth2/applications/" + this.settings.id + "/assets").Result;
					if (result.IsSuccessStatusCode)
					{
						result.Content.ReadAsAsync<List<ImageAssets>>().Result.ForEach(delegate(ImageAssets asset)
						{
							this.comboBoxLargeKey.Items.Add(asset.Name);
							this.comboBoxSmallKey.Items.Add(asset.Name);
						});
						this.nextAssetCheck = DateTime.Now.Add(new TimeSpan(0, 1, 0));
					}
				}
				catch
				{
					MessageBox.Show(Strings.errorNoInternet, Strings.error, MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00005DD4 File Offset: 0x00003FD4
		private void ButtonPaint(object sender, PaintEventArgs e)
		{
			System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
			button.Text = string.Empty;
			TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
			TextRenderer.DrawText(e.Graphics, this.res.GetString(button.Name + ".Text"), button.Font, e.ClipRectangle, button.Enabled ? button.ForeColor : CurrentColors.TextInactive, flags);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00005E3D File Offset: 0x0000403D
		private void Update(object sender, EventArgs e)
		{
			Utils.SaveSettings();
			this.SetPresence();
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00008910 File Offset: 0x00006B10
		[CompilerGenerated]
		internal static bool <.ctor>g__localePredicate|19_0(string loc)
		{
			string name = CultureInfo.CurrentUICulture.Name;
			return loc == name || loc == name.Split(new char[]
			{
				'-'
			})[0];
		}

		// Token: 0x0400003A RID: 58
		private List<DiscordRPC.Button> buttonsList = new List<DiscordRPC.Button>();

		// Token: 0x0400003B RID: 59
		private bool loading = true;

		// Token: 0x0400003C RID: 60
		private bool toAvoidRecursion;

		// Token: 0x0400003D RID: 61
		private System.Timers.Timer restartTimer = new System.Timers.Timer(10000.0);

		// Token: 0x0400003E RID: 62
		private int restartAttempts = 30;

		// Token: 0x0400003F RID: 63
		private int restartAttemptsLeft = -1;

		// Token: 0x04000040 RID: 64
		private Settings settings = Settings.Default;

		// Token: 0x04000041 RID: 65
		private GitHubClient githubClient = new GitHubClient(new ProductHeaderValue("CustomRP"));

		// Token: 0x04000042 RID: 66
		private Release latestRelease;

		// Token: 0x04000043 RID: 67
		private DateTime nextAssetCheck = DateTime.Now;

		// Token: 0x04000044 RID: 68
		private string lastIDChecked = "";

		// Token: 0x04000045 RID: 69
		private string localeUrl = "";

		// Token: 0x04000046 RID: 70
		private readonly DateTime timestampStarted = DateTime.UtcNow;

		// Token: 0x04000047 RID: 71
		private readonly string linkPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\CustomRP" + (Program.IsSecondInstance ? " 2" : "") + ".lnk";

		// Token: 0x04000048 RID: 72
		private readonly ComponentResourceManager res = new ComponentResourceManager(typeof(MainForm));

		// Token: 0x04000049 RID: 73
		private readonly List<string> translatedWikiLocales = new List<string>
		{
			"de",
			"es",
			"fi",
			"fr",
			"ko",
			"pl",
			"ru"
		};

		// Token: 0x0400004A RID: 74
		private readonly string U00A0 = "\u00a0";

		// Token: 0x0400004B RID: 75
		private readonly string U200B = "​";
	}
}
