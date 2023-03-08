using System;
using System.ComponentModel;

namespace CustomRPC
{
	// Token: 0x02000004 RID: 4
	public static class ConnectionManager
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000240D File Offset: 0x0000060D
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002414 File Offset: 0x00000614
		public static ConnectionType State
		{
			get
			{
				return ConnectionManager.current;
			}
			set
			{
				if (value == ConnectionType.None)
				{
					throw new InvalidEnumArgumentException("Attempt to set State to ConnectionType.None.");
				}
				if (ConnectionManager.current != ConnectionType.Connecting)
				{
					ConnectionManager.previous = ConnectionManager.current;
				}
				ConnectionManager.current = value;
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000243D File Offset: 0x0000063D
		public static bool HasChanged()
		{
			return ConnectionManager.current != ConnectionManager.previous;
		}

		// Token: 0x0400000E RID: 14
		private static ConnectionType current = ConnectionType.Disconnected;

		// Token: 0x0400000F RID: 15
		private static ConnectionType previous = ConnectionType.None;
	}
}
