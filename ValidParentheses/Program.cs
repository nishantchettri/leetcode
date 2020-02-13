using System;
using System.Collections.Generic;
namespace ValidParentheses
{
	class Program
	{
		static string s = "";
		static Dictionary<char, char> mappings = new Dictionary<char, char>();
		private static void Main(string[] args)
		{
			var res = isValid(s);
			Console.WriteLine(string.Join(",", res));
			Console.ReadLine();
		}
		// Hash table that takes care of the mappings.
		public static bool isValid(String s)
		{
			mappings.Add(')', '(');
			mappings.Add('}', '{');
			mappings.Add(']', '[');
			// Initialize a stack to be used in the algorithm.
			Stack<char> stack = new Stack<char>();
			for (int i = 0; i < s.Length; i++)
			{
				char c = s[i];
				// If the current character is a closing bracket.
				if (mappings.ContainsKey(c))
				{
					// Get the top element of the stack. If the stack is empty, set a dummy value of '#'
					char topElement = stack.Count == 0 ? '#' : stack.Pop();
					// If the mapping for this bracket doesn't match the stack's top element, return false.
					if (topElement != mappings[c])
					{
						return false;
					}
				}
				else
				{
					// If it was an opening bracket, push to the stack.
					stack.Push(c);
				}
			}
			// If the stack still contains elements, then it is an invalid expression.
			if (stack.Count == 0)
			{
				return true;
			}
			return false;
		}
	}
}
