using Practice.Helper.Nodes;

namespace Practice.Grind75.Easy
{
    public class MergeTwoSortedLists
    {

        public static Node MergeTwoLists(Node list1, Node list2)
        {
            // SET dummy node list
            var dummy = new Node();
            // SET newNodeList as dummy
            var newNodeList = dummy;
            // WHILE list1 is not empty and list2 is not empty
            while (list1 != null && list2 != null)
            {
                // IF list1.val < list2.val
                if (list1.val <= list2.val)
                {
                    // ADD to newNodeList
                    newNodeList.next = list1;
                    // UPDATE list1.val = list1.next
                    list1 = list1.next;
                    // IF list1.val > list2.val
                }
                else
                {
                    // ADD to newNodeList
                    newNodeList.next = list2;
                    // UPDATE list2.val = list2.next
                    list2 = list2.next;
                }
                newNodeList = newNodeList.next;
            }
            // IF list1 is not empty
            if (list1 != null)
            {
                // UPDATE newNodeList = list1
                newNodeList.next = list1;
                // IF list2 is not empty
            }
            else if (list2 != null)
            {
                // UPDATE newNodeList = list2
                newNodeList.next = list2;
            }
            // RETURN dummy.next
            return dummy.next;
        }
    }
}
