using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CustomRPC.Properties;

namespace CustomRPC
{
	// Token: 0x02000009 RID: 9
	public partial class ErrorReportViewer : Form
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00002834 File Offset: 0x00000A34
		public ErrorReportViewer(string stackTrace)
		{
			this.InitializeComponent();
			WinApi.UseImmersiveDarkMode(base.Handle);
			this.BackColor = (this.richTextBoxReport.BackColor = CurrentColors.BgColor);
			this.ForeColor = (this.richTextBoxReport.ForeColor = CurrentColors.TextColor);
			this.buttonOK.FlatStyle = (Settings.Default.darkMode ? FlatStyle.Flat : FlatStyle.Standard);
			this.richTextBoxReport.Text = stackTrace;
			this.richTextBoxReport.Select(0, stackTrace.Split(new char[]
			{
				'\n'
			})[0].Length);
			this.richTextBoxReport.SelectionFont = new Font(this.richTextBoxReport.Font.FontFamily, this.richTextBoxReport.Font.Size + 2f, FontStyle.Bold);
			this.richTextBoxReport.DeselectAll();
		}
	}
}
