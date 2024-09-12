using Practice.Helper;

namespace Practice.Grind75
{
    public class Results
    {
        public static void DisplayResults()
        {
            #region 1. Two Sum (LC 1)
            Print.PrintIntArray(Easy.TwoSum.TwoSumVersion1([2, 7, 11, 15], 9));
            Print.PrintIntArray(Easy.TwoSum.TwoSumVersion1([3, 2, 4], 6));
            Print.PrintIntArray(Easy.TwoSum.TwoSumVersion1([3, 3], 6)); Print.PrintIntArray(Easy.TwoSum.TwoSumVersion2([2, 7, 11, 15], 9));
            Print.PrintIntArray(Easy.TwoSum.TwoSumVersion2([3, 2, 4], 6));
            Print.PrintIntArray(Easy.TwoSum.TwoSumVersion2([3, 3], 6));
            #endregion

            #region 2. Valid Parentheses (LC 20)
            Console.WriteLine(Easy.ValidParentheses.IsValidVersion1("()"));
            Console.WriteLine(Easy.ValidParentheses.IsValidVersion1("()[]{}"));
            Console.WriteLine(Easy.ValidParentheses.IsValidVersion1("(]"));
            Console.WriteLine(Easy.ValidParentheses.IsValidVersion1("([])"));
            Console.WriteLine(Easy.ValidParentheses.IsValidVersion2("()"));
            Console.WriteLine(Easy.ValidParentheses.IsValidVersion2("()[]{}"));
            Console.WriteLine(Easy.ValidParentheses.IsValidVersion2("(]"));
            Console.WriteLine(Easy.ValidParentheses.IsValidVersion2("([])"));
            #endregion

            #region 3. Merge Two Sorted Lists (LC 21)
            var list1 = Helper.Convert.ArrayToListNode(new[] { 1, 2, 4 });
            var list2 = Helper.Convert.ArrayToListNode(new[] { 1, 3, 4 });
            Print.PrintListNode(Easy.MergeTwoSortedLists.MergeTwoLists(list1, list2));
            var list3 = Helper.Convert.ArrayToListNode(new int[0]);
            var list4 = Helper.Convert.ArrayToListNode(new int[0]);
            Print.PrintListNode(Easy.MergeTwoSortedLists.MergeTwoLists(list3, list4));
            var list5 = Helper.Convert.ArrayToListNode(new int[0]);
            var list6 = Helper.Convert.ArrayToListNode(new[] { 0 });
            Print.PrintListNode(Easy.MergeTwoSortedLists.MergeTwoLists(list5, list6));
            #endregion

            #region 4. Best Time to Buy and Sell Stock (LC 121)
            Console.WriteLine(Easy.BestTimeToBuyAndSellStock.MaxProfit([7, 1, 5, 3, 6, 4]));
            Console.WriteLine(Easy.BestTimeToBuyAndSellStock.MaxProfit([7, 6, 4, 3, 1]));
            #endregion

            #region 5. Valid Palindrome (LC 125)
            Console.WriteLine(Easy.ValidPalindrome.IsPalindrome("A man, a plan, a canal: Panama"));
            Console.WriteLine(Easy.ValidPalindrome.IsPalindrome("race a car"));
            Console.WriteLine(Easy.ValidPalindrome.IsPalindrome(" "));
            #endregion

            #region 6. Invert Binary Tree (LC 226)
            var tree1 = Helper.Convert.ArrayToTreeNode(new[] { 4, 2, 7, 1, 3, 6, 9 });
            var tree2 = Helper.Convert.ArrayToTreeNode(new[] { 2, 1, 3 });
            var tree3 = Helper.Convert.ArrayToTreeNode(new int[0]);
            Print.PrintTree(Easy.InvertBinaryTree.InvertTree(tree1));
            Print.PrintTree(Easy.InvertBinaryTree.InvertTree(tree2));
            Print.PrintTree(Easy.InvertBinaryTree.InvertTree(tree3));
            #endregion

            #region 7. Valid Anagram (LC 242)
            Console.WriteLine(Easy.ValidAnagram.IsAnagram("anagram", "nagaram"));
            Console.WriteLine(Easy.ValidAnagram.IsAnagram("rat", "car"));
            Console.WriteLine(Easy.ValidAnagram.IsAnagram("dracula", "alucard"));
            #endregion

            #region 8. Binary Search (LC 704)
            Console.WriteLine(Easy.BinarySearch.Search([-1, 0, 3, 5, 9, 12], 9));
            Console.WriteLine(Easy.BinarySearch.Search([-1, 0, 3, 5, 9, 12], 2));
            #endregion
        }
    }
}
