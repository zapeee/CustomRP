using System;
using System.IO;
using DiscordRPC.Logging;

namespace CustomRPC
{
	// Token: 0x02000011 RID: 17
	public class TimestampFileLogger : ILogger
	{
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00009127 File Offset: 0x00007327
		// (set) Token: 0x06000098 RID: 152 RVA: 0x0000912F File Offset: 0x0000732F
		public LogLevel Level { get; set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00009138 File Offset: 0x00007338
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00009140 File Offset: 0x00007340
		public string LogFile { get; set; }

		// Token: 0x0600009B RID: 155 RVA: 0x00009149 File Offset: 0x00007349
		public TimestampFileLogger(string path) : this(path, LogLevel.Trace)
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00009154 File Offset: 0x00007354
		public TimestampFileLogger(string path, LogLevel level)
		{
			this.Level = level;
			this.LogFile = path;
			this.filelock = new object();
			FileInfo fileInfo = new FileInfo(this.LogFile);
			if (fileInfo.Exists && fileInfo.Length >= 5242880L)
			{
				object obj = this.filelock;
				lock (obj)
				{
					File.Move(this.LogFile, this.LogFile + ".0");
					int num = 0;
					while (File.Exists(this.LogFile + "." + (num + 1).ToString()))
					{
						num++;
					}
					for (int i = num; i >= 0; i--)
					{
						File.Move(this.LogFile + "." + i.ToString(), this.LogFile + "." + (i + 1).ToString());
					}
				}
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00009264 File Offset: 0x00007464
		private void Log(string logType, LogLevel logLevel, string message, params object[] args)
		{
			if (this.Level > logLevel)
			{
				return;
			}
			object obj = this.filelock;
			lock (obj)
			{
				try
				{
					File.AppendAllText(this.LogFile, string.Concat(new string[]
					{
						"[",
						DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
						"] ",
						logType,
						": ",
						(args.Length != 0) ? string.Format(message, args) : message,
						"\r\n"
					}));
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000931C File Offset: 0x0000751C
		public void Trace(string message, params object[] args)
		{
			this.Log("TRCE", LogLevel.Trace, message, args);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000932C File Offset: 0x0000752C
		public void Info(string message, params object[] args)
		{
			this.Log("INFO", LogLevel.Info, message, args);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000933C File Offset: 0x0000753C
		public void Warning(string message, params object[] args)
		{
			this.Log("WARN", LogLevel.Warning, message, args);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000934C File Offset: 0x0000754C
		public void Error(string message, params object[] args)
		{
			this.Log(" ERR", LogLevel.Error, message, args);
		}

		// Token: 0x040000AD RID: 173
		private object filelock;
	}
}
