using System;

namespace methodoverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
			var x = 300;
			var y = 100;

			var answer = Add(x, y);

			var a = 10.34m;
			var b = 10.35m;

			var decimalAnswer = Add(a, b);
			var thirdAnswer = Add(answer, decimalAnswer, true);

			Console.WriteLine($"int add: {answer} decimal add: {decimalAnswer}");
			Console.WriteLine(thirdAnswer);
		}

        public static int Add(int num1, int num2)
		{
			return num1 + num2;
		}

		public static decimal Add(decimal num1, decimal num2)
		{
			return  num1 + num2;
		}

		public static string Add(int num1, int num2, bool isCheck)
		{
			var sum = num1 + num2;

			if (isCheck == true && sum > 1)
			{
				return $"{sum} dollars";
			}
			else if (isCheck == true && sum == 1)
			{
				return $"{sum} dollar";
			}
			else if (isCheck == true && sum < 1)
			{
				return $"{sum} dollars";
			}
			else
			{
				return sum.ToString();
			}

		}
		static decimal Add(int num1, decimal num2, bool isCheck)
		{
			return num1 + num2;
		}
	}
}
