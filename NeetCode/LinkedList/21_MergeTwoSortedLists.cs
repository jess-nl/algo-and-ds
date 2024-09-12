
using Practice.Helper.Nodes;

namespace Practice.NeetCode.LinkedList
{
    public class MergeTwoSortedLists
    {
        public static Node MergeTwoLists(Node l1, Node l2)
        {
            var dummy = new Node();
            var tail = dummy;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    tail.next = l1;
                    l1 = l1.next!;
                }
                else
                {
                    tail.next = l2;
                    l2 = l2.next!;
                }
                tail = tail.next;
            }

            if (l1 != null)
            {
                tail.next = l1;
            }
            else if (l2 != null)
            {
                tail.next = l2;
            }

            return dummy.next!;
        }
    }
}
