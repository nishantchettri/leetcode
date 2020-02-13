using System;
namespace MaxDepth
{
	class Program
	{
		static TreeNode node;
		static void Main(string[] args)
		{
			var res = MaxDepth(node);
			Console.WriteLine(string.Join(",", res));
			Console.ReadLine();
		}
		// Recursion - bottom up approach
		public static int MaxDepth(TreeNode root)
		{
			if (root == null)
			{
				return 0;
			}
			int left = MaxDepth(root.left);
			int right = MaxDepth(root.right);
			return Math.Max(left, right) + 1;
		}
		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			public TreeNode(int x) { val = x; }
		}
	}
}
