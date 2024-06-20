namespace Assignment7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            BinarySearchTree bst = new BinarySearchTree(ints);
            Node? newSubtreeRoot = bst.SearchBST(bst.Root, 3); // change the value to test different nodes
            BinarySearchTree newSubtree = new BinarySearchTree(newSubtreeRoot);
            newSubtree.PrintTree(newSubtree.Root);

        }
    }
}
