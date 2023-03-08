namespace CustomRPC
{
	// Token: 0x02000009 RID: 9
	public partial class ErrorReportViewer : global::System.Windows.Forms.Form
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00002918 File Offset: 0x00000B18
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002938 File Offset: 0x00000B38
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::CustomRPC.ErrorReportViewer));
			this.richTextBoxReport = new global::System.Windows.Forms.RichTextBox();
			this.buttonOK = new global::System.Windows.Forms.Button();
			this.labelInfo = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			componentResourceManager.ApplyResources(this.richTextBoxReport, "richTextBoxReport");
			this.richTextBoxReport.Name = "richTextBoxReport";
			this.richTextBoxReport.ReadOnly = true;
			componentResourceManager.ApplyResources(this.buttonOK, "buttonOK");
			this.buttonOK.BackColor = global::System.Drawing.Color.FromArgb(24, 25, 28);
			this.buttonOK.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonOK.FlatAppearance.BorderSize = 0;
			this.buttonOK.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(61, 73, 162);
			this.buttonOK.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(72, 86, 193);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.labelInfo, "labelInfo");
			this.labelInfo.Name = "labelInfo";
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.WhiteSmoke;
			base.Controls.Add(this.labelInfo);
			base.Controls.Add(this.buttonOK);
			base.Controls.Add(this.richTextBoxReport);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ErrorReportViewer";
			base.ResumeLayout(false);
		}

		// Token: 0x04000015 RID: 21
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.RichTextBox richTextBoxReport;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Button buttonOK;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Label labelInfo;
	}
}
