namespace L13_HomeWork_1
{
	public interface ILogWriter
	{
		void LogInfo(string message);
		void LogWarning(string message);
		void LogError(string message);
	}
}
