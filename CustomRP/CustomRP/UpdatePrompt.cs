using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Media;
using System.Windows.Forms;
using CustomRPC.Properties;
using TheArtOfDev.HtmlRenderer.WinForms;

namespace CustomRPC
{
	// Token: 0x02000019 RID: 25
	public partial class UpdatePrompt : Form
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x0000BFDC File Offset: 0x0000A1DC
		public UpdatePrompt(Version current, Version latest, string changelog)
		{
			this.InitializeComponent();
			WinApi.UseImmersiveDarkMode(base.Handle);
			this.BackColor = (this.htmlPanelChangelog.BackColor = CurrentColors.BgColor);
			this.ForeColor = CurrentColors.TextColor;
			if (this.ForeColor == Color.White)
			{
				HtmlPanel htmlPanel = this.htmlPanelChangelog;
				htmlPanel.BaseStylesheet += "* {color: white;}";
			}
			this.buttonSkipUpdate.FlatStyle = (this.buttonNotNow.FlatStyle = (this.buttonUpdate.FlatStyle = (Settings.Default.darkMode ? FlatStyle.Flat : FlatStyle.Standard)));
			string versionString = VersionHelper.GetVersionString(current);
			string versionString2 = VersionHelper.GetVersionString(latest);
			this.labelVersions.Text = versionString + "\r\n" + versionString2;
			this.htmlPanelChangelog.Text = changelog;
			SystemSounds.Beep.Play();
			base.Activate();
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000C0CC File Offset: 0x0000A2CC
		private void ToggleUpdates(object sender, EventArgs e)
		{
			Settings.Default.checkUpdates = !((CheckBox)sender).Checked;
			Utils.SaveSettings();
		}
	}
}
