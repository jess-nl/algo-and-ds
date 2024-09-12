using Practice.Helper.Nodes;

namespace Practice.Helper
{
    public class Convert
    {
        public static Node ArrayToListNode(int[] arr)
        {
            if (arr.Length == 0) return null;

            Node head = new Node(arr[0]);
            Node current = head;
            for (int i = 1; i < arr.Length; i++)
            {
                current.next = new Node(arr[i]);
                current = current.next;
            }
            return head;
        }

        public static TreeNode ArrayToTreeNode(int[] arr)
        {
            if (arr.Length == 0) return null;

            var root = new TreeNode(arr[0]);
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            int i = 1;
            while (i < arr.Length)
            {
                var node = queue.Dequeue();
                if (i < arr.Length)
                {
                    node._left = new TreeNode(arr[i++]);
                    queue.Enqueue(node._left);
                }
                if (i < arr.Length)
                {
                    node._right = new TreeNode(arr[i++]);
                    queue.Enqueue(node._right);
                }
            }

            return root;
        }
    }
}
