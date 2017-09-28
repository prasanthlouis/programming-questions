using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions.Microsoft
{
    public class BTisBinarySearchTreeOrNot
    {
        public class BinaryTree
        {
            public BinaryTree left;
            public BinaryTree right;
            public int data;
            public BinaryTree(int _data)
            {
                data = _data;
                left = null;
                right = null;
            }
        }
        internal void CheckIfItsBst()
        {
            var binaryTree = new BinaryTree(3);
            binaryTree.left = new BinaryTree(2);
            binaryTree.left.left = new BinaryTree(1);
            binaryTree.left.right = new BinaryTree(4);
            binaryTree.right = new BinaryTree(5);
            Console.WriteLine();
            Console.WriteLine($"Problem 1: Check if a binary tree is BST or not");
            Console.WriteLine(IsBst(binaryTree, int.MaxValue, int.MinValue));
        }

        private bool IsBst(BinaryTree binaryTree, int max, int min)
        {
            if (binaryTree == null)
                return true;

            if (binaryTree.data > max)
                return false;

            if (binaryTree.data < min)
                return false;

            return (IsBst(binaryTree.left, binaryTree.data-1, min ) && IsBst(binaryTree.right, max, binaryTree.data+1));
        }
    }
}
