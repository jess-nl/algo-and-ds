using Practice.Helper;
using Practice.NeetCode.DynamicArray;
using Practice.NeetCode.Stack;
using Practice.NeetCode.StaticArray;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var duplicatedArr = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Console.WriteLine(RemoveDuplicatesFromSortedArray.RemoveDuplicates(duplicatedArr));

            var extraElementArr = new int[] { 3, 2, 2, 3 };
            Console.WriteLine(RemoveElementSolution.RemoveElement(extraElementArr, 2));

            var unconcatenatedArr = new int[] { 1, 3, 2, 1 };
            Print.PrintIntArray(ConcatenationOfArray.GetConcatenationVersion1(unconcatenatedArr));
            Print.PrintIntArray(ConcatenationOfArray.GetConcatenationVersion2(unconcatenatedArr));

            Console.WriteLine(ValidParentheses.IsValid("(]"));

            var stack = new MinStack();
            stack.Push(8);
            stack.Push(20);
            stack.Push(22);
            stack.Pop();
            Console.WriteLine(stack.GetMin());
            Console.WriteLine(stack.Top());

            var operations = new string[] { "5", "2", "C", "D", "+" };
            Console.WriteLine(BaseballGame.CalPoints(operations));
        }
    }
}