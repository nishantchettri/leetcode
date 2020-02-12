using System;
using System.Collections.Generic;
public class MergeBinaryTrees
{
	static int[] s = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
	//static TreeNode t1 = new TreeNode() { 1, 3, 2, 5 };
	//static TreeNode t2 = new TreeNode() { 2, 1, 3, null, 4, null, 7 };
	static void Main(string[] args)
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
