using System;

namespace Alg_Lab._1_BST
{
    class BinarySearchTree
    {
        public Node root;

        public void Insert(int value)
        {
            root = InsertRec(root, value);
        }

        private Node InsertRec(Node root, int value)
        {
            if (root == null)
            {
                return new Node(value);
            }

            if (value < root.value)
            {
                root.Left = InsertRec(root.Left, value);
            }
            else if (value > root.value)
            {
                root.Right = InsertRec(root.Right, value);
            }

            return root;
        }

        public bool Search(int target)
        {
            return SearchRec(root, target);
        }


        private bool SearchRec(Node root, int target)
        {
            if (root == null)
            {
                return false;
            }

            if (target == root.value)
            {
                return true;
            }


            if (target < root.value)
            {
                return SearchRec(root.Left, target);
            }
            else
            {
                return SearchRec(root.Right, target);
            }
        }
    }
}
