﻿using System;
using System.Collections.Generic;

namespace FindDisappearedNumbers
{
	class Program
	{
		static int[] s = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
		private static void Main(string[] args)
		{
			var res = FindDisappearedNumberList(s);
			Console.WriteLine(string.Join(",", res));
			Console.ReadLine();
		}
		// Space Complexity: O(n)
		// Time Complexity: O(n)
		private static IList<int> FindDisappearedNumberList(int[] nums)
		{
			HashSet<int> sets = new HashSet<int>();
			List<int> missingNums = new List<int>();
			foreach (int num in nums)
			{
				sets.Add(num);
			}
			for (int i = 1; i <= nums.Length; i++)
			{
				if (!sets.Contains(i))
				{
					missingNums.Add(i);
				}
			}
			return missingNums;
		}
	}
}
