using System;

namespace HelloWorld2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			SetBackground(ConsoleColor.Cyan);
			Console.WriteLine("Hello World!");
			SetBackground(ConsoleColor.White);
		}

		public static void SetBackground(ConsoleColor color)
		{
			Console.ForegroundColor = color;
		}
	}
}
