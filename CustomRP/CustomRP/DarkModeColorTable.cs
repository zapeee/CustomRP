using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomRPC
{
	// Token: 0x02000006 RID: 6
	internal class DarkModeColorTable : ProfessionalColorTable
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000025E9 File Offset: 0x000007E9
		public override Color MenuItemSelected
		{
			get
			{
				return CurrentColors.BgHover;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000025F0 File Offset: 0x000007F0
		public override Color MenuItemPressedGradientBegin
		{
			get
			{
				return CurrentColors.BgActive;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000025F7 File Offset: 0x000007F7
		public override Color MenuItemPressedGradientEnd
		{
			get
			{
				return this.MenuItemPressedGradientBegin;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000025FF File Offset: 0x000007FF
		public override Color MenuItemPressedGradientMiddle
		{
			get
			{
				return this.MenuItemPressedGradientBegin;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002607 File Offset: 0x00000807
		public override Color MenuItemSelectedGradientBegin
		{
			get
			{
				return CurrentColors.BgHover;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000020 RID: 32 RVA: 0x0000260E File Offset: 0x0000080E
		public override Color MenuItemSelectedGradientEnd
		{
			get
			{
				return this.MenuItemSelectedGradientBegin;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002616 File Offset: 0x00000816
		public override Color ImageMarginGradientBegin
		{
			get
			{
				return CurrentColors.BgInactive;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000022 RID: 34 RVA: 0x0000261D File Offset: 0x0000081D
		public override Color ImageMarginGradientMiddle
		{
			get
			{
				return this.ImageMarginGradientBegin;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002625 File Offset: 0x00000825
		public override Color ImageMarginGradientEnd
		{
			get
			{
				return this.ImageMarginGradientBegin;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000024 RID: 36 RVA: 0x0000262D File Offset: 0x0000082D
		public override Color CheckSelectedBackground
		{
			get
			{
				return CurrentColors.CheckBg;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002634 File Offset: 0x00000834
		public override Color CheckBackground
		{
			get
			{
				return CurrentColors.CheckHover;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000026 RID: 38 RVA: 0x0000263B File Offset: 0x0000083B
		public override Color MenuItemBorder
		{
			get
			{
				return CurrentColors.BgActive;
			}
		}
	}
}
