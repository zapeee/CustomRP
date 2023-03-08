using System;
using System.Runtime.InteropServices;
using CustomRPC.Properties;

namespace CustomRPC
{
	// Token: 0x02000012 RID: 18
	public static class WinApi
	{
		// Token: 0x060000A2 RID: 162
		[DllImport("user32")]
		public static extern int RegisterWindowMessage(string message);

		// Token: 0x060000A3 RID: 163
		[DllImport("user32")]
		public static extern bool PostMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);

		// Token: 0x060000A4 RID: 164
		[DllImport("dwmapi.dll")]
		private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

		// Token: 0x060000A5 RID: 165 RVA: 0x0000935C File Offset: 0x0000755C
		public static bool UseImmersiveDarkMode(IntPtr handle)
		{
			if (WinApi.IsWindows10OrGreater(17763))
			{
				int attr = 19;
				if (WinApi.IsWindows10OrGreater(18985))
				{
					attr = 20;
				}
				int num = Settings.Default.darkMode ? 1 : 0;
				return WinApi.DwmSetWindowAttribute(handle, attr, ref num, 4) == 0;
			}
			return false;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000093A7 File Offset: 0x000075A7
		private static bool IsWindows10OrGreater(int build = -1)
		{
			return Environment.OSVersion.Version.Major >= 10 && Environment.OSVersion.Version.Build >= build;
		}

		// Token: 0x040000AE RID: 174
		private const int DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1 = 19;

		// Token: 0x040000AF RID: 175
		private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;
	}
}
