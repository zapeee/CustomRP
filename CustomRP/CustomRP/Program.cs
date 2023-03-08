using System;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomRPC.Properties;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace CustomRPC
{
	// Token: 0x0200000F RID: 15
	internal static class Program
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00008A0E File Offset: 0x00006C0E
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00008A15 File Offset: 0x00006C15
		public static Mutex AppMutex { get; private set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00008A1D File Offset: 0x00006C1D
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00008A24 File Offset: 0x00006C24
		public static bool IsSecondInstance { get; private set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00008A2C File Offset: 0x00006C2C
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00008A33 File Offset: 0x00006C33
		public static int WM_SHOWFIRSTINSTANCE { get; private set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00008A3B File Offset: 0x00006C3B
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00008A42 File Offset: 0x00006C42
		public static int WM_IMPORTPRESET { get; private set; }

		// Token: 0x0600007C RID: 124 RVA: 0x00008A4C File Offset: 0x00006C4C
		[STAThread]
		private static void Main(string[] args)
		{
			string text = null;
			string text2 = "CustomRP";
			bool flag = false;
			if (args.Length != 0 && (args[0] == "--help" || args[0] == "-?"))
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendLine("Usage: CustomRP.exe [options] [file]");
				stringBuilder.AppendLine("-2, --second-instance: open as second instance");
				stringBuilder.AppendLine("-s, --silent-import: silent preset import");
				stringBuilder.AppendLine("-?, --help: shows this help text");
				MessageBox.Show(stringBuilder.ToString(), Application.ProductName);
				return;
			}
			foreach (string text3 in args)
			{
				if (text3 == "--second-instance" || text3 == "-2")
				{
					Program.IsSecondInstance = true;
					text2 += " 2";
				}
				if (text3 == "--silent-import" || text3 == "-s")
				{
					flag = true;
				}
				if (File.Exists(text3))
				{
					text = text3;
				}
			}
			Program.WM_SHOWFIRSTINSTANCE = WinApi.RegisterWindowMessage("WM_SHOWFIRSTINSTANCE|" + text2);
			Program.WM_IMPORTPRESET = WinApi.RegisterWindowMessage("WM_IMPORTPRESET|" + text2);
			bool flag2;
			Program.AppMutex = new Mutex(true, text2, ref flag2);
			if (!flag2)
			{
				if (!flag)
				{
					WinApi.PostMessage(new IntPtr(65535), Program.WM_SHOWFIRSTINSTANCE, IntPtr.Zero, IntPtr.Zero);
				}
				if (text != null)
				{
					try
					{
						File.Copy(text, Path.GetTempPath() + "preset.crp", true);
						WinApi.PostMessage(new IntPtr(65535), Program.WM_IMPORTPRESET, IntPtr.Zero, IntPtr.Zero);
					}
					catch
					{
						MessageBox.Show(Strings.errorInvalidPresetFile, Strings.error, MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
				return;
			}
			Settings settings = Settings.Default;
			string text4 = "auto";
			try
			{
				text4 = settings.language;
			}
			catch (ConfigurationErrorsException ex)
			{
				if (MessageBox.Show(Strings.errorCorruptSettings, Strings.error, MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
				{
					File.Delete(((ConfigurationErrorsException)ex.InnerException).Filename);
					Program.AppMutex.Close();
					Application.Restart();
				}
				return;
			}
			if (text4 != "auto")
			{
				CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo(text4);
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);
			try
			{
				if (!settings.analyticsAskedConsent)
				{
					bool flag3 = MessageBox.Show(Strings.askAnalyticsConsent, Strings.information, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes;
					Analytics.SetEnabledAsync(flag3);
					settings.analytics = flag3;
					settings.analyticsAskedConsent = true;
					Utils.SaveSettings();
				}
				Crashes.ShouldProcessErrorReport = ((ErrorReport report) => !report.StackTrace.StartsWith("Microsoft.AppCenter.Crashes.TestCrashException"));
				Crashes.GetErrorAttachments = delegate(ErrorReport report)
				{
					StringBuilder stringBuilder3 = new StringBuilder();
					foreach (object obj in settings.PropertyValues)
					{
						SettingsPropertyValue settingsPropertyValue = (SettingsPropertyValue)obj;
						if (!(settingsPropertyValue.Name == "id"))
						{
							StringBuilder stringBuilder4 = stringBuilder3;
							string name = settingsPropertyValue.Name;
							string str = " = ";
							object serializedValue = settingsPropertyValue.SerializedValue;
							stringBuilder4.AppendLine(name + str + ((serializedValue != null) ? serializedValue.ToString() : null));
						}
					}
					StringBuilder stringBuilder5 = new StringBuilder();
					string[] array = File.ReadAllLines(Application.StartupPath + "\\rpc.log");
					int num = array.Length - 1;
					while (num >= 0 && num >= array.Length - 200)
					{
						if (!array[num].Contains("applicationID"))
						{
							stringBuilder5.Insert(0, array[num] + "\r\n");
						}
						num--;
					}
					return new ErrorAttachmentLog[]
					{
						ErrorAttachmentLog.AttachmentWithText(stringBuilder3.ToString(), "settings.txt"),
						ErrorAttachmentLog.AttachmentWithText(stringBuilder5.ToString(), "rpc.log")
					};
				};
				AppCenter.SetCountryCode(RegionInfo.CurrentRegion.TwoLetterISORegionName);
				AppCenter.Start("141506f2-5a6b-46c5-a70e-693831ee131a", new Type[]
				{
					typeof(Analytics),
					typeof(Crashes)
				});
				IntPtr handle = new MainForm(text).Handle;
				Application.Run();
			}
			catch (Exception ex2)
			{
				StringBuilder stringBuilder2 = new StringBuilder();
				stringBuilder2.AppendLine(DateTime.Now.ToLocalTime().ToString());
				stringBuilder2.AppendLine(ex2.ToString());
				stringBuilder2.AppendLine();
				bool flag4 = true;
				while (flag4)
				{
					try
					{
						File.AppendAllText(Application.StartupPath + "\\crash.log", stringBuilder2.ToString());
						flag4 = false;
					}
					catch
					{
						Task.Delay(100);
						flag4 = true;
					}
				}
				Exception ex3 = ex2;
				while (ex3.InnerException != null)
				{
					ex3 = ex3.InnerException;
				}
				if ((!(ex3 is FileNotFoundException) || !ex3.Message.Contains("Version=")) && !(ex3 is FileLoadException) && !(ex3 is BadImageFormatException))
				{
					MessageBox.Show(ex2.ToString(), "CustomRP - " + Strings.error, MessageBoxButtons.OK, MessageBoxIcon.Hand);
					throw;
				}
				if (MessageBox.Show(ex3.Message + "\r\n\r\n" + string.Format(Strings.errorLoadingAssembly, Application.StartupPath), Strings.error, MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand) == DialogResult.Retry)
				{
					Program.AppMutex.Close();
					Application.Restart();
				}
			}
			finally
			{
				Utils.SaveSettings();
			}
			GC.KeepAlive(Program.AppMutex);
		}
	}
}
