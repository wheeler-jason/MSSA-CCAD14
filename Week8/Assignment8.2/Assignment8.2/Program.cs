namespace Assignment8._2
{
    /*
     * Given the root of a binary tree, check whether it is
     * a mirror of itself (i.e., symmetric around its center).
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public bool IsSymmetric(TreeNode root)
        {
            return IsMirror(root.left, root.right);
        }

        public bool IsMirror(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null)
            {
                return true;
            }
            if (t1 == null || t2 == null)
            {
                return false;
            }
            if(t1.val != t2.val)
            {
                return false;
            }
            return IsMirror(t1.left, t2.right) && IsMirror(t1.right, t2.left);
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}
