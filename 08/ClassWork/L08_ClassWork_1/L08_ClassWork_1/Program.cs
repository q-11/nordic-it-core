using System;
using System.IO;
using System.Text;

namespace L08_ClassWork_1
{
	class Program
	{
		static void Main(string[] args)
		{
			const string fileName = @"file.txt";
			const string content = "Never mind 2";

			//MemoryStream ms = new MemoryStream ()

			//FileStream stream = File.Create(fileName, 4096);

			//stream.Seek(0, SeekOrigin.End);

			//stream.WriteByte(13);
			//stream.WriteByte(10);

			//stream.Write(bytesOfContent);
			//byte[] bytesOfContent = Encoding.ASCII.GetBytes(content);

			FileStream stream = File.Open(
				fileName,
				FileMode.Open,
				FileAccess.Read,
				FileShare.Read);

			const int readBufferSize = 5;
			byte[] bytesOfContent = new byte [readBufferSize];
			string result = String.Empty;
			int bytesRead;
			do
			{
				bytesRead = stream.Read(
					bytesOfContent,
					0,
					readBufferSize);

				result += Encoding.ASCII.GetString(
					bytesOfContent,
					0,
					bytesRead);

				Encoding.ASCII.GetString(
					bytesOfContent,
					0,
					bytesRead);

			} while (bytesRead > 0);

			stream.Close();
		}
	}
}
