using System;

namespace CustomRPC
{
	// Token: 0x0200000B RID: 11
	[Serializable]
	public struct Preset
	{
		// Token: 0x04000021 RID: 33
		public string ID;

		// Token: 0x04000022 RID: 34
		public string Details;

		// Token: 0x04000023 RID: 35
		public string State;

		// Token: 0x04000024 RID: 36
		public int PartySize;

		// Token: 0x04000025 RID: 37
		public int PartyMax;

		// Token: 0x04000026 RID: 38
		public int Timestamps;

		// Token: 0x04000027 RID: 39
		public DateTime CustomTimestamp;

		// Token: 0x04000028 RID: 40
		public string LargeKey;

		// Token: 0x04000029 RID: 41
		public string LargeText;

		// Token: 0x0400002A RID: 42
		public string SmallKey;

		// Token: 0x0400002B RID: 43
		public string SmallText;

		// Token: 0x0400002C RID: 44
		public string Button1Text;

		// Token: 0x0400002D RID: 45
		public string Button1URL;

		// Token: 0x0400002E RID: 46
		public string Button2Text;

		// Token: 0x0400002F RID: 47
		public string Button2URL;
	}
}
