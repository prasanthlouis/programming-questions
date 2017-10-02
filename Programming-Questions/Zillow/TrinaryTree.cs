using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions.Zillow
{
    public class TrinaryTree
    {
        internal void PerformTraversal()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Problem 7: Insert and delete nodes in a trinary tree.");

            var tree = ConstructTTree();
            TraverseTree(tree);
            Console.WriteLine();
            InsertNode(tree, new TTree(3));
            TraverseTree(tree);
            Console.WriteLine();
            DeleteNode(tree, 3);
            TraverseTree(tree);
            Console.WriteLine();
        }

        private TTree DeleteNode(TTree tree, int v)
        {
            if (tree == null)
                return null;
            if (tree._data > v)
                tree.left = DeleteNode(tree.left, v);
            else if (tree._data < v)
                tree.right = DeleteNode(tree.right, v);
            else
            {
                if (tree.middle != null)
                    tree.middle = DeleteNode(tree.middle, v);
                else if(tree.right != null)
                {
                    var minimumNode = FindMinimum(tree.right);
                    tree._data = minimumNode._data;
                    tree.right = DeleteNode(tree.right, minimumNode._data);
                }
                else
                {
                    tree = tree.left;
                }
            }
            return tree;
        }

        private TTree FindMinimum(TTree tree)
        {
            if(tree != null)
            {
                while(tree.left != null)
                {
                    tree = tree.left;
                }
            }
            return tree;
        }

        private void InsertNode(TTree tree, TTree newNode)
        {
            if (newNode == null)
                return;

            var parent = tree;
            var current = parent;
            while(current != null)
            {
                parent = current;
                if (parent._data > newNode._data)
                    current = parent.left;
                else if (parent._data < newNode._data)
                    current = parent.right;
                else if (parent._data == newNode._data)
                    current = parent.middle;
            }
            if (parent._data > newNode._data)
                parent.left = newNode;
            else if (parent._data < newNode._data)
                parent.right = newNode;
            else if (parent._data == newNode._data)
                current = parent.middle;


        }

        private void TraverseTree(TTree tree)
        {
            if (tree == null)
                return;
            if (tree.left != null)
            { 
                TraverseTree(tree.left);
                }
            if (tree.middle != null)
            {
                TraverseTree(tree.middle);
            }
            if (tree.right != null)
            {
                TraverseTree(tree.right);
            }
            Console.Write($"{tree._data}->");

        }

        private TTree ConstructTTree()
        {
            var tree = new TTree(5);
            tree.left = new TTree(4);
            tree.middle = new TTree(5);
            tree.right = new TTree(9);
            tree.left.left = new TTree(2);
            tree.left.left.middle = new TTree(2);
            tree.right.left = new TTree(7);
            return tree;
        }
    }

    public class TTree
    {
        public TTree left;
        public TTree right;
        public TTree middle;
        public int _data;
        public TTree(int data)
        {
            _data = data;
            left = null;
            right = null;
            middle = null;
        }
    }
}
