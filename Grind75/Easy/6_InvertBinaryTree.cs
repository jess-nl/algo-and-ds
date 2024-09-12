using Practice.Helper.Nodes;

namespace Practice.Grind75.Easy
{
    public class InvertBinaryTree
    {
        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            var temp = root._left;
            root._left = InvertTree(root._right);
            root._right = InvertTree(temp);

            return root;
        }
    }
}
