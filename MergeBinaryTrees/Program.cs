using System;
namespace MergeBinaryTrees
{
	class Program
	{
		private static void Main(string[] args)
		{
			var res = MergeTrees(null, null);
			Console.WriteLine(string.Join(",", res));
			Console.ReadLine();
		}
		// Space Complexity: O(n)
		// Time Complexity: O(n)
		private static TreeNode MergeTrees(TreeNode t1, TreeNode t2)
		{
			if (t1 == null)
			{
				return t2;
			}
			if (t2 == null)
			{
				return t1;
			}
			t1.val += t2.val;
			t1.left = MergeTrees(t1.left, t2.left);
			t1.right = MergeTrees(t1.right, t2.right);
			return t1;
		}
		private class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			public TreeNode(int x) { val = x; }
		}
	}
}
