using System;
using System.Collections.Generic;

namespace MajorityElement
{
	class Program
	{
		static int[] s = new int[] { 2, 2, 1, 1, 1, 2, 2 };
		private static void Main(string[] args)
		{
			var res = FindMajorityElement(s);
			Console.WriteLine(string.Join(",", res));
			Console.ReadLine();
		}
		// Space Complexity: O(n)
		// Time Complexity: O(n)
		private static int FindMajorityElement(int[] nums)
		{
			Dictionary<int, int> numCount = new Dictionary<int, int>();
			foreach (int num in nums)
			{
				if (numCount.ContainsKey(num))
				{
					numCount[num]++;
				}
				else
				{
					numCount.Add(num, 1);
				}
			}

			foreach (KeyValuePair<int, int> entry in numCount)
			{
				if (entry.Value > nums.Length / 2)
				{
					return entry.Key;
				}
			}
			return -1;
		}
	}
}
