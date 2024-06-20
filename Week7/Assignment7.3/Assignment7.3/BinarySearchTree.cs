using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7._3
{
    internal class BinarySearchTree
    {

        public Node? Root { get; private set; }

        public BinarySearchTree()
        {
            Root = null;
        }

        public BinarySearchTree(Node root)
        {
            Root = root;
        }

        // constructor that initializes the BST with an array of ints
        public BinarySearchTree(int[] initializeArray)
        {
            Root = null;
            Array.Sort(initializeArray);
            InitializeBST(initializeArray, 0, initializeArray.Length - 1);
        }

        // inserts the elements in a way that makes the tree balanced
        private void InitializeBST(int[] arr, int start, int end)
        {
            if (start > end)
            {
                return;
            }

            int mid = (start + end) / 2;
            Insert(arr[mid]);
            InitializeBST(arr, start, mid - 1);
            InitializeBST(arr, mid + 1, end);
        }

        public Node SearchBST(Node root, int val)
        {
            if (root == null)
            {
                return null;
            }

            if (val == root.Value)
            {
                return root;
            }
            if (val > root.Value)
            {
                return SearchBST(root.Right, val);
            }
            else
            {
                return SearchBST(root.Left, val);
            }
        }

        public void Insert(int value)
        {
            Root = InsertRec(Root, value);
        }

        private Node InsertRec(Node root, int value)
        {
            if (root == null)
            {
                root = new Node(value);
                return root;
            }

            if (value < root.Value)
                root.Left = InsertRec(root.Left, value);
            else if (value > root.Value)
                root.Right = InsertRec(root.Right, value);

            return root;
        }

        public void PrintTree(Node root)
        {
            PrintTreeRec(Root);
        }

        private void PrintTreeRec(Node root)
        {
            if (root != null)
            {
                PrintTreeRec(root.Left);
                Console.WriteLine(root.Value);
                PrintTreeRec(root.Right);
            }
        }

        public bool Contains(int value)
        {
            return ContainsRec(Root, value);
        }

        private bool ContainsRec(Node root, int value)
        {
            if (root == null)
                return false;

            if (value == root.Value)
                return true;
            else if (value < root.Value)
                return ContainsRec(root.Left, value);
            else
                return ContainsRec(root.Right, value);
        }
    }
}

