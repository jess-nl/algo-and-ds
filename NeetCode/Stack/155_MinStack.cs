﻿namespace Practice.NeetCode.Stack
{
    public class MinStack
    {
        public Stack<int> stack;
        public Stack<int> minStack;

        public MinStack()
        {
            stack = new Stack<int>();
            minStack = new Stack<int>();
        }

        public void Push(int val)
        {
            stack.Push(val);
            var min = Math.Min(val, minStack.Count > 0 ? minStack.Peek() : val);
            minStack.Push(min);
        }

        public void Pop()
        {
            stack.Pop();
            minStack.Pop();
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
