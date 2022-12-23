using System;
namespace IntermediateCSharp
{
	public class Calculator
	{
		public int Add(params int[] numbers)
		{
			var sum = 0;
			foreach(int number in numbers)
			{
				sum += number;
			}

			return sum;
		}
	}
}

