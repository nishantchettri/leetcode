using System;

namespace HouseRobber
{
	class Program
	{
        static int[] s = new int[] { 1, 2, 3, 1 };
        private static void Main(string[] args)
        {
            var res = HouseRobber(s);
            Console.WriteLine(string.Join(",", res));
            Console.ReadLine();
        }
        // Space Complexity: O(n)
        // Time Complexity: O(n)
        // Dynamic Programming
        private static int HouseRobber(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            if (nums.Length == 1)
            {
                return nums[0];
            }

            if (nums.Length == 2)
            {
                return Math.Max(nums[0], nums[1]);
            }

            int[] dp = new int[nums.Length];
            dp[0] = nums[0];
            dp[1] = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < nums.Length; i++)
            {
                dp[i] = Math.Max(nums[i] + dp[i - 2], dp[i - 1]);
            }
            return dp[nums.Length - 1];
        }
    }
}
