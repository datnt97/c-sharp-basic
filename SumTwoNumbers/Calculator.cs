using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumTwoNumbers
{
	public class Calculator
	{
		public Calculator()
		{

		}

		public int SumTwoNumber(int firstValue, int secondValue) => firstValue + secondValue;

		public double SumTwoNumber(double firstValue, double secondValue) => firstValue + secondValue;

		public double SumTwoNumber(int firstValue, double secondValue) => (double)(firstValue) + secondValue;

		public double SumTwoNumber(double firstValue, int secondValue) => firstValue + (double)secondValue;

		public int TryEnterNumber()
		{
			bool invalidNumber = false;
			int result = 0;

			do
			{
				Console.Write("\nEnter a number: ");
				string numberValue = Console.ReadLine();
				invalidNumber = !Int32.TryParse(numberValue, out int number);

				if (!invalidNumber)
				{
					result = number;
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Invalid number. Please try again");
					Console.ForegroundColor = ConsoleColor.White;
				}

			} while (invalidNumber);

			return result;
		}
	}
}
