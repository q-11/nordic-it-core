using System;
using System.Collections.Generic;
using System.Text;

namespace L13_HomeWork_1
{
	public class MultipleLogWriter: AbstractLogWriter, IDisposable
	{
		private ILogWriter[] _internalWriters;
		public MultipleLogWriter(ILogWriter[] internalWriters)
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
