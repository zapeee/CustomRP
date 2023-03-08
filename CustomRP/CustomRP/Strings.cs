using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace CustomRPC
{
	// Token: 0x02000010 RID: 16
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Strings
	{
		// Token: 0x0600007D RID: 125 RVA: 0x00008F00 File Offset: 0x00007100
		internal Strings()
		{
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00008F08 File Offset: 0x00007108
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Strings.resourceMan == null)
				{
					Strings.resourceMan = new ResourceManager("CustomRPC.Strings", typeof(Strings).Assembly);
				}
				return Strings.resourceMan;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00008F34 File Offset: 0x00007134
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00008F3B File Offset: 0x0000713B
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Strings.resourceCulture;
			}
			set
			{
				Strings.resourceCulture = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00008F43 File Offset: 0x00007143
		internal static string askAnalyticsConsent
		{
			get
			{
				return Strings.ResourceManager.GetString("askAnalyticsConsent", Strings.resourceCulture);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00008F59 File Offset: 0x00007159
		internal static string error
		{
			get
			{
				return Strings.ResourceManager.GetString("error", Strings.resourceCulture);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00008F6F File Offset: 0x0000716F
		internal static string errorCannotConnect
		{
			get
			{
				return Strings.ResourceManager.GetString("errorCannotConnect", Strings.resourceCulture);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00008F85 File Offset: 0x00007185
		internal static string errorCorruptSettings
		{
			get
			{
				return Strings.ResourceManager.GetString("errorCorruptSettings", Strings.resourceCulture);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00008F9B File Offset: 0x0000719B
		internal static string errorInvalidImageURL
		{
			get
			{
				return Strings.ResourceManager.GetString("errorInvalidImageURL", Strings.resourceCulture);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00008FB1 File Offset: 0x000071B1
		internal static string errorInvalidPresetFile
		{
			get
			{
				return Strings.ResourceManager.GetString("errorInvalidPresetFile", Strings.resourceCulture);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00008FC7 File Offset: 0x000071C7
		internal static string errorInvalidURL
		{
			get
			{
				return Strings.ResourceManager.GetString("errorInvalidURL", Strings.resourceCulture);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00008FDD File Offset: 0x000071DD
		internal static string errorLoadingAssembly
		{
			get
			{
				return Strings.ResourceManager.GetString("errorLoadingAssembly", Strings.resourceCulture);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00008FF3 File Offset: 0x000071F3
		internal static string errorNoID
		{
			get
			{
				return Strings.ResourceManager.GetString("errorNoID", Strings.resourceCulture);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00009009 File Offset: 0x00007209
		internal static string errorNoInternet
		{
			get
			{
				return Strings.ResourceManager.GetString("errorNoInternet", Strings.resourceCulture);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600008B RID: 139 RVA: 0x0000901F File Offset: 0x0000721F
		internal static string errorSavingSettings
		{
			get
			{
				return Strings.ResourceManager.GetString("errorSavingSettings", Strings.resourceCulture);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00009035 File Offset: 0x00007235
		internal static string errorStartupShortcut
		{
			get
			{
				return Strings.ResourceManager.GetString("errorStartupShortcut", Strings.resourceCulture);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600008D RID: 141 RVA: 0x0000904B File Offset: 0x0000724B
		internal static string errorUpdateFailed
		{
			get
			{
				return Strings.ResourceManager.GetString("errorUpdateFailed", Strings.resourceCulture);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00009061 File Offset: 0x00007261
		internal static string firstTimeRun
		{
			get
			{
				return Strings.ResourceManager.GetString("firstTimeRun", Strings.resourceCulture);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00009077 File Offset: 0x00007277
		internal static string firstTimeRunText
		{
			get
			{
				return Strings.ResourceManager.GetString("firstTimeRunText", Strings.resourceCulture);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0000908D File Offset: 0x0000728D
		internal static string information
		{
			get
			{
				return Strings.ResourceManager.GetString("information", Strings.resourceCulture);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000091 RID: 145 RVA: 0x000090A3 File Offset: 0x000072A3
		internal static string noUpdatesFound
		{
			get
			{
				return Strings.ResourceManager.GetString("noUpdatesFound", Strings.resourceCulture);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000092 RID: 146 RVA: 0x000090B9 File Offset: 0x000072B9
		internal static string statusConnected
		{
			get
			{
				return Strings.ResourceManager.GetString("statusConnected", Strings.resourceCulture);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000093 RID: 147 RVA: 0x000090CF File Offset: 0x000072CF
		internal static string statusConnecting
		{
			get
			{
				return Strings.ResourceManager.GetString("statusConnecting", Strings.resourceCulture);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000094 RID: 148 RVA: 0x000090E5 File Offset: 0x000072E5
		internal static string statusConnectionFailed
		{
			get
			{
				return Strings.ResourceManager.GetString("statusConnectionFailed", Strings.resourceCulture);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000090FB File Offset: 0x000072FB
		internal static string statusDisconnected
		{
			get
			{
				return Strings.ResourceManager.GetString("statusDisconnected", Strings.resourceCulture);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00009111 File Offset: 0x00007311
		internal static string statusError
		{
			get
			{
				return Strings.ResourceManager.GetString("statusError", Strings.resourceCulture);
			}
		}

		// Token: 0x040000A9 RID: 169
		private static ResourceManager resourceMan;

		// Token: 0x040000AA RID: 170
		private static CultureInfo resourceCulture;
	}
}
