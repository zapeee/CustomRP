using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace CustomRPC.Properties
{
	// Token: 0x0200001A RID: 26
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x060000BC RID: 188 RVA: 0x0000C5FB File Offset: 0x0000A7FB
		internal Resources()
		{
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000C603 File Offset: 0x0000A803
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("CustomRPC.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0000C62F File Offset: 0x0000A82F
		// (set) Token: 0x060000BF RID: 191 RVA: 0x0000C636 File Offset: 0x0000A836
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0000C63E File Offset: 0x0000A83E
		internal static Icon favicon
		{
			get
			{
				return (Icon)Resources.ResourceManager.GetObject("favicon", Resources.resourceCulture);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x0000C659 File Offset: 0x0000A859
		internal static Bitmap globe
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("globe", Resources.resourceCulture);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0000C674 File Offset: 0x0000A874
		internal static Bitmap globe_white
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("globe_white", Resources.resourceCulture);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000C68F File Offset: 0x0000A88F
		internal static Bitmap logo
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("logo", Resources.resourceCulture);
			}
		}

		// Token: 0x040000D8 RID: 216
		private static ResourceManager resourceMan;

		// Token: 0x040000D9 RID: 217
		private static CultureInfo resourceCulture;
	}
}
