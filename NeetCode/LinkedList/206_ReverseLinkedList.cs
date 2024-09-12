using Practice.Helper.Nodes;

namespace Practice.NeetCode.LinkedList
{
    public class ReverseLinkedList
    {
        public Node ReverseList(Node head)
        {
            Node previous = null;
            var current = head;

            while (current != null)
            {
                var next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }

            return previous;
        }
    }
}
