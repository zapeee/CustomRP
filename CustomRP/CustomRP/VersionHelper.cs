using System;

namespace CustomRPC
{
	// Token: 0x02000018 RID: 24
	internal static class VersionHelper
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x0000BE8C File Offset: 0x0000A08C
		public static Version GetVersion(string version)
		{
			if (string.IsNullOrEmpty(version))
			{
				throw new ArgumentNullException("version");
			}
			if (version.StartsWith("v"))
			{
				version = version.Substring(1);
			}
			string[] array = version.Split(new char[]
			{
				'.'
			});
			if (array.Length < 2 || array.Length > 4)
			{
				throw new ArgumentException(string.Format("Version has {0} part(s)!", array.Length), "version");
			}
			int num = array.Length;
			if (num == 2)
			{
				return Version.Parse(version + ".0.0");
			}
			if (num != 3)
			{
				return Version.Parse(version);
			}
			return Version.Parse(version + ".0");
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000BF34 File Offset: 0x0000A134
		public static string GetVersionString(Version version)
		{
			if (version == null)
			{
				throw new ArgumentNullException("version");
			}
			string text = version.Major.ToString() + "." + version.Minor.ToString();
			if (version.Build > 0 || version.Revision > 0)
			{
				text = text + "." + version.Build.ToString();
			}
			if (version.Revision > 0)
			{
				text = text + "." + version.Revision.ToString();
			}
			return text;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000BFCC File Offset: 0x0000A1CC
		public static string GetVersionString(string version)
		{
			return VersionHelper.GetVersionString(Version.Parse(version));
		}
	}
}
