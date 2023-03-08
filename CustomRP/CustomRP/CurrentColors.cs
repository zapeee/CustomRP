using System;
using System.Drawing;
using CustomRPC.Properties;

namespace CustomRPC
{
	// Token: 0x02000005 RID: 5
	public static class CurrentColors
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000009 RID: 9 RVA: 0x0000245C File Offset: 0x0000065C
		public static Color BgInactive
		{
			get
			{
				return Color.FromArgb(47, 49, 54);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002469 File Offset: 0x00000669
		public static Color BgHover
		{
			get
			{
				return Color.FromArgb(52, 55, 60);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002476 File Offset: 0x00000676
		public static Color BgActive
		{
			get
			{
				return Color.FromArgb(57, 60, 67);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002483 File Offset: 0x00000683
		public static Color CheckBg
		{
			get
			{
				return Color.FromArgb(61, 73, 162);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002493 File Offset: 0x00000693
		public static Color CheckHover
		{
			get
			{
				return Color.FromArgb(72, 86, 193);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000024A3 File Offset: 0x000006A3
		public static Color TextInactive
		{
			get
			{
				return Color.FromArgb(142, 146, 151);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000024B9 File Offset: 0x000006B9
		// (set) Token: 0x06000010 RID: 16 RVA: 0x000024C0 File Offset: 0x000006C0
		public static Color BgColor { get; private set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000024C8 File Offset: 0x000006C8
		// (set) Token: 0x06000012 RID: 18 RVA: 0x000024CF File Offset: 0x000006CF
		public static Color BgTextFields { get; private set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000024D7 File Offset: 0x000006D7
		// (set) Token: 0x06000014 RID: 20 RVA: 0x000024DE File Offset: 0x000006DE
		public static Color BgTextFieldsSuccess { get; private set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000024E6 File Offset: 0x000006E6
		// (set) Token: 0x06000016 RID: 22 RVA: 0x000024ED File Offset: 0x000006ED
		public static Color BgTextFieldsError { get; private set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000017 RID: 23 RVA: 0x000024F5 File Offset: 0x000006F5
		// (set) Token: 0x06000018 RID: 24 RVA: 0x000024FC File Offset: 0x000006FC
		public static Color TextColor { get; private set; }

		// Token: 0x06000019 RID: 25 RVA: 0x00002504 File Offset: 0x00000704
		static CurrentColors()
		{
			CurrentColors.Update();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000250C File Offset: 0x0000070C
		public static void Update()
		{
			if (Settings.Default.darkMode)
			{
				CurrentColors.BgColor = Color.FromArgb(55, 57, 63);
				CurrentColors.BgTextFields = Color.FromArgb(65, 68, 75);
				CurrentColors.BgTextFieldsSuccess = Color.FromArgb(50, 150, 50);
				CurrentColors.BgTextFieldsError = Color.FromArgb(150, 50, 50);
				CurrentColors.TextColor = Color.White;
				return;
			}
			CurrentColors.BgColor = Color.FromArgb(255, 255, 255);
			CurrentColors.BgTextFields = Color.FromArgb(235, 237, 239);
			CurrentColors.BgTextFieldsSuccess = Color.FromArgb(192, 255, 192);
			CurrentColors.BgTextFieldsError = Color.FromArgb(255, 192, 192);
			CurrentColors.TextColor = Color.FromName("ControlText");
		}
	}
}
