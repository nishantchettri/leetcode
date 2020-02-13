using System.Collections.Generic;
namespace LeetCode
{
    // Getting min values from stack in constant time
    public class MinStack
    {
        Stack<int> minStack = new Stack<int>();
        Stack<int> stack = new Stack<int>();
        public void Push(int x)
        {
            if (minStack.Count == 0 || x <= minStack.Peek())
            {
                minStack.Push(x);
            }
            stack.Push(x);
        }
        public void Pop()
        {
            if (stack.Peek() == minStack.Peek())
            {
                minStack.Pop();
            }
            stack.Pop();
        }
        public int Top()
        {
            return stack.Peek();
        }
        public int GetMin()
        {
            return minStack.Peek();
        }
    }
}
