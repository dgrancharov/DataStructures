using System;
using System.Collections.Generic;
using System.Linq;

namespace SortArrayOfNumbers
{
	class MainClass
	{
		public static void Main ()
		{
			char[] separators = new char[] {' '};
			List<int> numbers = Console.ReadLine ().Split (separators, StringSplitOptions.RemoveEmptyEntries)
				.Select(x => int.Parse(x)).ToList();

			numbers.Sort ();

			foreach (int number in numbers) 
			{
				Console.Write ("{0} ",number);
			}
			Console.WriteLine ();
		}
	}
}
