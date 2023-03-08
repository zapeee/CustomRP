namespace CustomRPC
{
	// Token: 0x02000019 RID: 25
	public partial class UpdatePrompt : global::System.Windows.Forms.Form
	{
		// Token: 0x060000BA RID: 186 RVA: 0x0000C0EC File Offset: 0x0000A2EC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000C10C File Offset: 0x0000A30C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::CustomRPC.UpdatePrompt));
			this.buttonUpdate = new global::System.Windows.Forms.Button();
			this.pictureBoxLogo = new global::System.Windows.Forms.PictureBox();
			this.buttonNotNow = new global::System.Windows.Forms.Button();
			this.labelQuestion = new global::System.Windows.Forms.Label();
			this.checkBoxNeverNotify = new global::System.Windows.Forms.CheckBox();
			this.labelVersionsText = new global::System.Windows.Forms.Label();
			this.labelVersions = new global::System.Windows.Forms.Label();
			this.buttonSkipUpdate = new global::System.Windows.Forms.Button();
			this.htmlPanelChangelog = new global::TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxLogo).BeginInit();
			base.SuspendLayout();
			componentResourceManager.ApplyResources(this.buttonUpdate, "buttonUpdate");
			this.buttonUpdate.AutoEllipsis = true;
			this.buttonUpdate.BackColor = global::System.Drawing.Color.FromArgb(24, 25, 28);
			this.buttonUpdate.DialogResult = global::System.Windows.Forms.DialogResult.Yes;
			this.buttonUpdate.FlatAppearance.BorderSize = 0;
			this.buttonUpdate.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(61, 73, 162);
			this.buttonUpdate.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(72, 86, 193);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.pictureBoxLogo, "pictureBoxLogo");
			this.pictureBoxLogo.Image = global::CustomRPC.Properties.Resources.logo;
			this.pictureBoxLogo.Name = "pictureBoxLogo";
			this.pictureBoxLogo.TabStop = false;
			componentResourceManager.ApplyResources(this.buttonNotNow, "buttonNotNow");
			this.buttonNotNow.AutoEllipsis = true;
			this.buttonNotNow.BackColor = global::System.Drawing.Color.FromArgb(24, 25, 28);
			this.buttonNotNow.DialogResult = global::System.Windows.Forms.DialogResult.No;
			this.buttonNotNow.FlatAppearance.BorderSize = 0;
			this.buttonNotNow.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(61, 73, 162);
			this.buttonNotNow.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(72, 86, 193);
			this.buttonNotNow.Name = "buttonNotNow";
			this.buttonNotNow.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.labelQuestion, "labelQuestion");
			this.labelQuestion.Name = "labelQuestion";
			componentResourceManager.ApplyResources(this.checkBoxNeverNotify, "checkBoxNeverNotify");
			this.checkBoxNeverNotify.Name = "checkBoxNeverNotify";
			this.checkBoxNeverNotify.UseVisualStyleBackColor = true;
			this.checkBoxNeverNotify.CheckedChanged += new global::System.EventHandler(this.ToggleUpdates);
			componentResourceManager.ApplyResources(this.labelVersionsText, "labelVersionsText");
			this.labelVersionsText.Name = "labelVersionsText";
			componentResourceManager.ApplyResources(this.labelVersions, "labelVersions");
			this.labelVersions.Name = "labelVersions";
			componentResourceManager.ApplyResources(this.buttonSkipUpdate, "buttonSkipUpdate");
			this.buttonSkipUpdate.AutoEllipsis = true;
			this.buttonSkipUpdate.BackColor = global::System.Drawing.Color.FromArgb(24, 25, 28);
			this.buttonSkipUpdate.DialogResult = global::System.Windows.Forms.DialogResult.Ignore;
			this.buttonSkipUpdate.FlatAppearance.BorderSize = 0;
			this.buttonSkipUpdate.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(61, 73, 162);
			this.buttonSkipUpdate.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(72, 86, 193);
			this.buttonSkipUpdate.Name = "buttonSkipUpdate";
			this.buttonSkipUpdate.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.htmlPanelChangelog, "htmlPanelChangelog");
			this.htmlPanelChangelog.BackColor = global::System.Drawing.SystemColors.Window;
			this.htmlPanelChangelog.BaseStylesheet = componentResourceManager.GetString("htmlPanelChangelog.BaseStylesheet");
			this.htmlPanelChangelog.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.htmlPanelChangelog.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.htmlPanelChangelog.Name = "htmlPanelChangelog";
			this.htmlPanelChangelog.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.htmlPanelChangelog.UseGdiPlusTextRendering = true;
			base.AcceptButton = this.buttonUpdate;
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.WhiteSmoke;
			base.CancelButton = this.buttonNotNow;
			base.Controls.Add(this.htmlPanelChangelog);
			base.Controls.Add(this.buttonSkipUpdate);
			base.Controls.Add(this.labelVersions);
			base.Controls.Add(this.labelVersionsText);
			base.Controls.Add(this.checkBoxNeverNotify);
			base.Controls.Add(this.labelQuestion);
			base.Controls.Add(this.buttonNotNow);
			base.Controls.Add(this.pictureBoxLogo);
			base.Controls.Add(this.buttonUpdate);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "UpdatePrompt";
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxLogo).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000CE RID: 206
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000CF RID: 207
		private global::System.Windows.Forms.Button buttonUpdate;

		// Token: 0x040000D0 RID: 208
		private global::System.Windows.Forms.PictureBox pictureBoxLogo;

		// Token: 0x040000D1 RID: 209
		private global::System.Windows.Forms.Button buttonNotNow;

		// Token: 0x040000D2 RID: 210
		private global::System.Windows.Forms.Label labelQuestion;

		// Token: 0x040000D3 RID: 211
		private global::System.Windows.Forms.CheckBox checkBoxNeverNotify;

		// Token: 0x040000D4 RID: 212
		private global::System.Windows.Forms.Label labelVersionsText;

		// Token: 0x040000D5 RID: 213
		private global::System.Windows.Forms.Label labelVersions;

		// Token: 0x040000D6 RID: 214
		private global::System.Windows.Forms.Button buttonSkipUpdate;

		// Token: 0x040000D7 RID: 215
		private global::TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel htmlPanelChangelog;
	}
}
