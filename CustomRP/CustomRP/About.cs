using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using CustomRPC.Properties;

namespace CustomRPC
{
	// Token: 0x02000002 RID: 2
	public partial class About : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public About()
		{
			this.InitializeComponent();
			WinApi.UseImmersiveDarkMode(base.Handle);
			this.BackColor = CurrentColors.BgColor;
			this.ForeColor = CurrentColors.TextColor;
			this.buttonClose.FlatStyle = (Settings.Default.darkMode ? FlatStyle.Flat : FlatStyle.Standard);
			this.labelVersion.Text = VersionHelper.GetVersionString(Application.ProductVersion);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020BB File Offset: 0x000002BB
		private void OpenWebsite(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://www.customrp.xyz");
		}
	}
}
