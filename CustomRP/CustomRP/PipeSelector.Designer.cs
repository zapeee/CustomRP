namespace CustomRPC
{
	// Token: 0x0200000A RID: 10
	public partial class PipeSelector : global::System.Windows.Forms.Form
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00002C60 File Offset: 0x00000E60
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002C80 File Offset: 0x00000E80
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::CustomRPC.PipeSelector));
			this.numericUpDownPipe = new global::System.Windows.Forms.NumericUpDown();
			this.labelDefault = new global::System.Windows.Forms.Label();
			this.pictureBoxAvatar = new global::System.Windows.Forms.PictureBox();
			this.labelUsername = new global::System.Windows.Forms.Label();
			this.buttonOK = new global::System.Windows.Forms.Button();
			this.labelPipe = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDownPipe).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxAvatar).BeginInit();
			base.SuspendLayout();
			componentResourceManager.ApplyResources(this.numericUpDownPipe, "numericUpDownPipe");
			this.numericUpDownPipe.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", global::CustomRPC.Properties.Settings.Default, "pipe", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDownPipe;
			int[] array = new int[4];
			array[0] = 9;
			numericUpDown.Maximum = new decimal(array);
			this.numericUpDownPipe.Minimum = new decimal(new int[]
			{
				1,
				0,
				0,
				int.MinValue
			});
			this.numericUpDownPipe.Name = "numericUpDownPipe";
			this.numericUpDownPipe.ReadOnly = true;
			this.numericUpDownPipe.Value = global::CustomRPC.Properties.Settings.Default.pipe;
			this.numericUpDownPipe.ValueChanged += new global::System.EventHandler(this.PipeChanged);
			componentResourceManager.ApplyResources(this.labelDefault, "labelDefault");
			this.labelDefault.Name = "labelDefault";
			componentResourceManager.ApplyResources(this.pictureBoxAvatar, "pictureBoxAvatar");
			this.pictureBoxAvatar.Name = "pictureBoxAvatar";
			this.pictureBoxAvatar.TabStop = false;
			componentResourceManager.ApplyResources(this.labelUsername, "labelUsername");
			this.labelUsername.Name = "labelUsername";
			componentResourceManager.ApplyResources(this.buttonOK, "buttonOK");
			this.buttonOK.BackColor = global::System.Drawing.Color.FromArgb(24, 25, 28);
			this.buttonOK.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonOK.FlatAppearance.BorderSize = 0;
			this.buttonOK.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(61, 73, 162);
			this.buttonOK.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(72, 86, 193);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.labelPipe, "labelPipe");
			this.labelPipe.Name = "labelPipe";
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.WhiteSmoke;
			base.CancelButton = this.buttonOK;
			base.Controls.Add(this.labelPipe);
			base.Controls.Add(this.buttonOK);
			base.Controls.Add(this.labelUsername);
			base.Controls.Add(this.pictureBoxAvatar);
			base.Controls.Add(this.labelDefault);
			base.Controls.Add(this.numericUpDownPipe);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "PipeSelector";
			base.ShowIcon = false;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.DisposeClient);
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDownPipe).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxAvatar).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400001A RID: 26
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.NumericUpDown numericUpDownPipe;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Label labelDefault;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.PictureBox pictureBoxAvatar;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Label labelUsername;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Button buttonOK;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Label labelPipe;
	}
}
