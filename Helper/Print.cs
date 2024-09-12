using System.Text;
using Practice.Helper.Nodes;

namespace Practice.Helper
{
    public static class Print
    {
        public static void PrintIntArray(this int[] array)
        {
            Console.WriteLine(string.Join(", ", array.Select(x => x.ToString())));
        }

        public static void PrintListNode(Node node)
        {
            var sb = new StringBuilder();
            while (node != null)
            {
                sb.Append(node.val).Append(" -> ");
                node = node.next;
            }
            sb.Append("null");
            Console.WriteLine(sb.ToString());
        }

        public static void PrintTree(TreeNode node)
        {
            if (node == null)
            {
                Console.WriteLine("null");
                return;
            }

            var sb = new StringBuilder();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                if (current != null)
                {
                    sb.Append(current._val).Append(" ");
                    queue.Enqueue(current._left);
                    queue.Enqueue(current._right);
                }
                else
                {
                    sb.Append("null ");
                }
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
