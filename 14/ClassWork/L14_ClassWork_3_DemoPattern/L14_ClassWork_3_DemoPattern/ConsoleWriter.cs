namespace L14_ClassWork_3_DemoPattern
{
	class ConsoleWriter
	{
		private static ConsoleWriter _instance;
		private ConsoleWriter()
		{

		}
		public static ConsoleWriter GetInstance()
		{
			if (_instance == null) 
			{
				_instance = new ConsoleWriter();
			}
			return _instance;
		}
	}
}
