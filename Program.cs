using System;

namespace MultithreadedTesting
{
	class Program
	{
		static void Main(string[] args)
		{
			var sum = new Sum(randomiser.Next(1000), randomiser.Next(2000));
			
			Console.WriteLine($"The sum of ${sum.LhsValue} + {sum.RhsValue} = {sum}");
		}
	}
}
