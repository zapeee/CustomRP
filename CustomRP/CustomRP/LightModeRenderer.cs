using System;
using System.Drawing;
using System.Windows.Forms;
using CustomRPC.Properties;

namespace CustomRPC
{
	// Token: 0x02000008 RID: 8
	internal class LightModeRenderer : ToolStripProfessionalRenderer
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00002786 File Offset: 0x00000986
		protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
		{
			e.ToolStrip.BackColor = Color.FromArgb(242, 243, 245);
			base.OnRenderToolStripBackground(e);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000027B0 File Offset: 0x000009B0
		protected override void OnRenderItemImage(ToolStripItemImageRenderEventArgs e)
		{
			base.OnRenderItemImage(e);
			if (e.Item.Tag == null)
			{
				return;
			}
			if (e.Item.Image.Tag == null || (string)e.Item.Image.Tag == "dark")
			{
				e.Item.Image = Resources.globe;
				e.Item.Image.Tag = "light";
			}
		}
	}
}
