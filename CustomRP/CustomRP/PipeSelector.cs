using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CustomRPC.Properties;
using DiscordRPC;
using DiscordRPC.Message;

namespace CustomRPC
{
	// Token: 0x0200000A RID: 10
	public partial class PipeSelector : Form
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00002ADC File Offset: 0x00000CDC
		public PipeSelector()
		{
			this.InitializeComponent();
			WinApi.UseImmersiveDarkMode(base.Handle);
			this.BackColor = (this.numericUpDownPipe.BackColor = CurrentColors.BgColor);
			this.ForeColor = (this.numericUpDownPipe.ForeColor = CurrentColors.TextColor);
			this.buttonOK.FlatStyle = (Settings.Default.darkMode ? FlatStyle.Flat : FlatStyle.Standard);
			this.TestConnection();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002B54 File Offset: 0x00000D54
		private void TestConnection()
		{
			if (this.client != null && !this.client.IsDisposed)
			{
				this.client.Dispose();
			}
			this.client = new DiscordRpcClient("896771305108553788", (int)this.numericUpDownPipe.Value, null, true, null);
			this.client.OnReady += this.ConnectionSuccessful;
			this.client.OnConnectionFailed += this.ConnectionFailed;
			this.client.Initialize();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002BDE File Offset: 0x00000DDE
		private void ConnectionSuccessful(object sender, ReadyMessage args)
		{
			base.Invoke(new MethodInvoker(delegate()
			{
				this.pictureBoxAvatar.ImageLocation = this.client.CurrentUser.GetAvatarURL(User.AvatarFormat.PNG);
				this.labelUsername.Text = this.client.CurrentUser.ToString().Replace("#", "\n#");
			}));
			this.client.Dispose();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002BFE File Offset: 0x00000DFE
		private void ConnectionFailed(object sender, ConnectionFailedMessage args)
		{
			base.Invoke(new MethodInvoker(delegate()
			{
				this.pictureBoxAvatar.ImageLocation = "https://cdn.discordapp.com/embed/avatars/4.png";
				this.labelUsername.Text = "Can't connect.";
			}));
			this.client.Dispose();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002C1E File Offset: 0x00000E1E
		private void PipeChanged(object sender, EventArgs e)
		{
			this.TestConnection();
			this.pictureBoxAvatar.ImageLocation = "https://cdn.discordapp.com/embed/avatars/1.png";
			this.labelUsername.Text = "Connecting...";
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002C46 File Offset: 0x00000E46
		private void DisposeClient(object sender, FormClosingEventArgs e)
		{
			if (!this.client.IsDisposed)
			{
				this.client.Dispose();
			}
		}

		// Token: 0x04000019 RID: 25
		private DiscordRpcClient client;
	}
}
