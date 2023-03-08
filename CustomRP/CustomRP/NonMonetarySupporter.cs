using System;

namespace CustomRPC
{
	// Token: 0x02000016 RID: 22
	internal struct NonMonetarySupporter
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x000093FB File Offset: 0x000075FB
		public NonMonetarySupporter(Person person, string DonationType = "", string DonationUrl = "")
		{
			this.Name = person.Name;
			this.Url = person.Url;
			this.DonationType = DonationType;
			this.DonationUrl = DonationUrl;
		}

		// Token: 0x040000BB RID: 187
		public string Name;

		// Token: 0x040000BC RID: 188
		public string Url;

		// Token: 0x040000BD RID: 189
		public string DonationType;

		// Token: 0x040000BE RID: 190
		public string DonationUrl;
	}
}
