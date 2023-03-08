using System;
using System.Drawing;
using System.Windows.Forms;
using CustomRPC.Properties;

namespace CustomRPC
{
	// Token: 0x02000007 RID: 7
	internal class DarkModeRenderer : ToolStripProfessionalRenderer
	{
		// Token: 0x06000028 RID: 40 RVA: 0x0000264A File Offset: 0x0000084A
		public DarkModeRenderer() : base(new DarkModeColorTable())
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002658 File Offset: 0x00000858
		protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
		{
			base.OnRenderToolStripBorder(e);
			e.Graphics.DrawRectangle(new Pen(CurrentColors.BgActive, 2f), e.AffectedBounds);
			e.Graphics.FillRectangle(new SolidBrush(CurrentColors.BgInactive), e.ConnectedArea);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000026A7 File Offset: 0x000008A7
		protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
		{
			e.TextColor = ((e.Item.ForeColor == Control.DefaultForeColor) ? CurrentColors.TextColor : e.Item.ForeColor);
			base.OnRenderItemText(e);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000026DF File Offset: 0x000008DF
		protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
		{
			e.ToolStrip.BackColor = CurrentColors.BgInactive;
			base.OnRenderToolStripBackground(e);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000026F8 File Offset: 0x000008F8
		protected override void OnRenderItemImage(ToolStripItemImageRenderEventArgs e)
		{
			base.OnRenderItemImage(e);
			if (e.Item.Tag == null)
			{
				return;
			}
			if (e.Item.Image.Tag == null || (string)e.Item.Image.Tag == "light")
			{
				e.Item.Image = Resources.globe_white;
				e.Item.Image.Tag = "dark";
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002772 File Offset: 0x00000972
		protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
		{
			e.ArrowColor = CurrentColors.TextColor;
			base.OnRenderArrow(e);
		}
	}
}
