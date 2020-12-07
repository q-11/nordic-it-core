using System;
using System.Collections.Generic;
using System.Text;

namespace L14_HomeWork
{
	public abstract class AbstractLogWriter : ILogWriter
	{
		private string _format = "{0:yyyy-MM-ddThh:mm:ss+0000}\t{1}\t{2}";
		public void LogError(string message)
		{
			WriteSingleLine(string.Format(_format, DateTimeOffset.Now, LogErrorType.Error, message));
		}
		public void LogInfo(string message)
		{
			WriteSingleLine(string.Format(_format, DateTimeOffset.Now, LogErrorType.Info, message));
		}
		public void LogWarning(string message)
		{
			WriteSingleLine(string.Format(_format, DateTimeOffset.Now, LogErrorType.Warning, message));
		}
		protected abstract void WriteSingleLine(string singleLine);
	}
}
