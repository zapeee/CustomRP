namespace CustomRPC
{
	// Token: 0x02000002 RID: 2
	public partial class About : global::System.Windows.Forms.Form
	{
		// Token: 0x06000003 RID: 3 RVA: 0x000020C8 File Offset: 0x000002C8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020E8 File Offset: 0x000002E8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::CustomRPC.About));
			this.pictureBoxLogo = new global::System.Windows.Forms.PictureBox();
			this.labelTitle = new global::System.Windows.Forms.Label();
			this.labelMadeBy = new global::System.Windows.Forms.Label();
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.labelVersion = new global::System.Windows.Forms.Label();
			this.linkLabelWebsite = new global::System.Windows.Forms.LinkLabel();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxLogo).BeginInit();
			base.SuspendLayout();
			this.pictureBoxLogo.Image = global::CustomRPC.Properties.Resources.logo;
			componentResourceManager.ApplyResources(this.pictureBoxLogo, "pictureBoxLogo");
			this.pictureBoxLogo.Name = "pictureBoxLogo";
			this.pictureBoxLogo.TabStop = false;
			componentResourceManager.ApplyResources(this.labelTitle, "labelTitle");
			this.labelTitle.Name = "labelTitle";
			componentResourceManager.ApplyResources(this.labelMadeBy, "labelMadeBy");
			this.labelMadeBy.Name = "labelMadeBy";
			this.buttonClose.AutoEllipsis = true;
			this.buttonClose.BackColor = global::System.Drawing.Color.FromArgb(24, 25, 28);
			this.buttonClose.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonClose.FlatAppearance.BorderSize = 0;
			this.buttonClose.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(61, 73, 162);
			this.buttonClose.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(72, 86, 193);
			componentResourceManager.ApplyResources(this.buttonClose, "buttonClose");
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.labelVersion, "labelVersion");
			this.labelVersion.Name = "labelVersion";
			this.linkLabelWebsite.ActiveLinkColor = global::System.Drawing.Color.FromArgb(237, 66, 69);
			componentResourceManager.ApplyResources(this.linkLabelWebsite, "linkLabelWebsite");
			this.linkLabelWebsite.LinkBehavior = global::System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.linkLabelWebsite.LinkColor = global::System.Drawing.Color.FromArgb(88, 101, 242);
			this.linkLabelWebsite.Name = "linkLabelWebsite";
			this.linkLabelWebsite.TabStop = true;
			this.linkLabelWebsite.VisitedLinkColor = global::System.Drawing.Color.FromArgb(88, 101, 242);
			this.linkLabelWebsite.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenWebsite);
			base.AcceptButton = this.buttonClose;
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.WhiteSmoke;
			base.CancelButton = this.buttonClose;
			base.Controls.Add(this.linkLabelWebsite);
			base.Controls.Add(this.labelVersion);
			base.Controls.Add(this.buttonClose);
			base.Controls.Add(this.labelMadeBy);
			base.Controls.Add(this.labelTitle);
			base.Controls.Add(this.pictureBoxLogo);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "About";
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxLogo).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000002 RID: 2
		private global::System.Windows.Forms.PictureBox pictureBoxLogo;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.Label labelTitle;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Label labelMadeBy;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Button buttonClose;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Label labelVersion;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.LinkLabel linkLabelWebsite;
	}
}
