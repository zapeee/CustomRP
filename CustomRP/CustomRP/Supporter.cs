using System;

namespace CustomRPC
{
	// Token: 0x02000015 RID: 21
	internal struct Supporter
	{
		// Token: 0x060000A7 RID: 167 RVA: 0x000093D3 File Offset: 0x000075D3
		public Supporter(Person person, string USDAmount = "", string AltAmount = "")
		{
			this.Name = person.Name;
			this.Url = person.Url;
			this.USDAmount = USDAmount;
			this.AltAmount = AltAmount;
		}

		// Token: 0x040000B7 RID: 183
		public string Name;

		// Token: 0x040000B8 RID: 184
		public string Url;

		// Token: 0x040000B9 RID: 185
		public string USDAmount;

		// Token: 0x040000BA RID: 186
		public string AltAmount;
	}
}
