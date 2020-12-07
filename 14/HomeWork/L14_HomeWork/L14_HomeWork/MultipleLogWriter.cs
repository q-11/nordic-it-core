using System;
using System.Collections.Generic;
using System.Text;

namespace L14_HomeWork
{
	public class MultipleLogWriter: AbstractLogWriter, IDisposable
	{
		private static MultipleLogWriter _instance;
		public static MultipleLogWriter GetInstance(ILogWriter[] internalWriters)
		{
			if (_instance == null)
				_instance = new MultipleLogWriter(internalWriters);
			return _instance;
		}

		private ILogWriter[] _internalWriters;
		private MultipleLogWriter(ILogWriter[] internalWriters)
		{
			_internalWriters = internalWriters;
		}
		protected override void WriteSingleLine(string singleLine)
		{
			throw new NotImplementedException();
		}
		public void Dispose()
		{
			foreach (var internalWriters in _internalWriters)
			{
				if (internalWriters is IDisposable && internalWriters != null)
				{
					(internalWriters as IDisposable).Dispose();
				}
			}
		}
	}
}
