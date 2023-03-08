using System;

namespace CustomRPC
{
	// Token: 0x02000003 RID: 3
	public enum ConnectionType
	{
		// Token: 0x04000009 RID: 9
		None = -1,
		// Token: 0x0400000A RID: 10
		Disconnected,
		// Token: 0x0400000B RID: 11
		Connecting,
		// Token: 0x0400000C RID: 12
		Connected,
		// Token: 0x0400000D RID: 13
		Error
	}
}
