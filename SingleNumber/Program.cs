using System;
using System.Collections.Generic;

namespace SingleNumber
{
	class Program
	{
		static int[] s = new int[] { 4, 1, 2, 1, 2 };
		private static void Main(string[] args)
		{
			var res = FindSingleNumber(s);
			Console.WriteLine(string.Join(",", res));
			Console.ReadLine();
		}
		// Space Complexity: O(n)
		// Time Complexity: O(n)
		private static int FindSingleNumber(int[] nums)
		{
			HashSet<int> sets = new HashSet<int>();
			foreach (int i in nums)
			{
				if (sets.Contains(i))
				{
					sets.Remove(i);
				}
				else
				{
					sets.Add(i);
				}
			}
			List<int> newList = new List<int>(sets);
			return newList[0];
		}
	}
}
