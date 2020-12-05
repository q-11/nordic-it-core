using System;
using System.IO;
using System.Text;

namespace L13_HomeWork_1
{
	public class FileLogWriter : AbstractLogWriter, IDisposable
	{
		private StreamWriter _logFileWriter;
		public FileLogWriter(string fileName = "log.txt")
		{
			_logFileWriter = new StreamWriter(File.Open(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read));
			_logFileWriter.BaseStream.Seek(0, SeekOrigin.End);
		}
		protected override void WriteSingleLine(string singleLine)
		{
			_logFileWriter.WriteLine(singleLine);
			_logFileWriter.Flush();
		}
		public void Dispose()
		{
			if (_logFileWriter != null)
			{
				_logFileWriter.Dispose();
			}
		}
	}
}
