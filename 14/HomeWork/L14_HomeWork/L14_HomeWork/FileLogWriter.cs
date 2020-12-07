using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace L14_HomeWork
{
	public class FileLogWriter : AbstractLogWriter, IDisposable
	{
		private static FileLogWriter _instance;
		public static FileLogWriter GetInstance()
		{
			if (_instance == null)
				_instance = new FileLogWriter();
			return _instance;
		}
		private StreamWriter _logFileWriter;
		private FileLogWriter(string fileName = "log.txt")
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
