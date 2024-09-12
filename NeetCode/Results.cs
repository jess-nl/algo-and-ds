using Practice.Helper;
using Practice.Helper.Nodes;
using Practice.NeetCode.DynamicArray;
using Practice.NeetCode.LinkedList;
using Practice.NeetCode.Stack;
using Practice.NeetCode.StaticArray;

namespace Practice.NeetCode
{
    public class Results
    {
        public static void DisplayResults()
        {
            #region Static Array | Remove Duplicates from Sorted Array (LC 26)
            var duplicatedArr = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Console.WriteLine(RemoveDuplicatesFromSortedArray.CountUniqueNumbers(duplicatedArr));
            var duplicatedArr2 = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4, 5, 5, 5 };
            Print.PrintIntArray(RemoveDuplicatesFromSortedArray.DisplayUniqueNumbers(duplicatedArr2));
            #endregion

            #region Static Array | Remove Element (LC 27)
            var extraElementArr1 = new int[] { 3, 2, 2, 3 };
            Console.WriteLine(RemoveElementSolution.RemoveElement(extraElementArr1, 3));
            var extraElementArr2 = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            Console.WriteLine(RemoveElementSolution.RemoveElement(extraElementArr2, 2));
            #endregion

            #region Dynamic Array | Concatenation of Array (LC 1929)
            var unconcatenatedArr1 = new int[] { 1, 2, 1 };
            Print.PrintIntArray(ConcatenationOfArray.GetConcatenationVersion1(unconcatenatedArr1));
            Print.PrintIntArray(ConcatenationOfArray.GetConcatenationVersion2(unconcatenatedArr1));

            var unconcatenatedArr2 = new int[] { 1, 3, 2, 1 };
            Print.PrintIntArray(ConcatenationOfArray.GetConcatenationVersion1(unconcatenatedArr2));
            Print.PrintIntArray(ConcatenationOfArray.GetConcatenationVersion2(unconcatenatedArr2));
            #endregion

            #region Stack | Valid Parentheses (LC 20)
            Console.WriteLine(ValidParentheses.IsValid("()"));
            Console.WriteLine(ValidParentheses.IsValid("()[]{}"));
            Console.WriteLine(ValidParentheses.IsValid("(]"));
            Console.WriteLine(ValidParentheses.IsValid("([])"));
            #endregion

            #region Stack | Min Stack (LC 155)
            var stack = new MinStack();
            stack.Push(8);
            stack.Push(20);
            stack.Push(22);
            stack.Pop();
            Console.WriteLine(stack.GetMin());
            Console.WriteLine(stack.Top());
            #endregion

            #region Stack | Baseball Game (LC 682)
            var operations1 = new string[] { "5", "2", "C", "D", "+" };
            Console.WriteLine(BaseballGame.CalPoints(operations1));

            var operations2 = new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" };
            Console.WriteLine(BaseballGame.CalPoints(operations2));

            var operations3 = new string[] { "1", "C" };
            Console.WriteLine(BaseballGame.CalPoints(operations3));
            #endregion

            #region Linked List | Reverse Linked List (LC 206)
            // 1 -> 2 -> 3 -> 4 -> 5 -> null
            var head = new Node(1, new Node(2, new Node(3, new Node(4, new Node(5)))));

            Console.WriteLine("Original Linked List:");
            Print.PrintListNode(head);

            var reverser = new ReverseLinkedList();
            var reversedHead = reverser.ReverseList(head);

            Console.WriteLine("\nReversed Linked List:");
            Print.PrintListNode(reversedHead);
            #endregion

            #region Linked List | Merge Two Sorted Lists (LC 21)
            var list1 = Helper.Convert.ArrayToListNode(new[] { 1, 2, 4 });
            var list2 = Helper.Convert.ArrayToListNode(new[] { 1, 3, 4 });
            Print.PrintListNode(LinkedList.MergeTwoSortedLists.MergeTwoLists(list1, list2));

            var list3 = Helper.Convert.ArrayToListNode(new int[0]);
            var list4 = Helper.Convert.ArrayToListNode(new int[0]);
            Print.PrintListNode(LinkedList.MergeTwoSortedLists.MergeTwoLists(list3, list4));

            var list5 = Helper.Convert.ArrayToListNode(new int[0]);
            var list6 = Helper.Convert.ArrayToListNode(new[] { 0 });
            Print.PrintListNode(LinkedList.MergeTwoSortedLists.MergeTwoLists(list5, list6));
            #endregion
        }
    }
}
