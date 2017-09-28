using System;
using System.Collections.Generic;

namespace Programming_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            //Find the k largest or smallest in an array
            var kLargest_SmallestInAnArray = new KLargest_SmallestInAnArray(new int[] { 3, 6, 7, 8, 4, 5, 2, 1, 0, 9 }, 5);
            kLargest_SmallestInAnArray.Solution();
            Console.WriteLine();

            //Problem 2
            //Find a triplet. If found, print true else print false
            var triplet = new CheckForTriplet(new int[] { 5, 8, 9, 2, 4, 3 });
            triplet.Solution();
            Console.WriteLine();

            var noTriplet = new CheckForTriplet(new int[] { 5, 8, 9, 2, 4, 7 });
            noTriplet.Solution();
            Console.WriteLine();

            //Problem 3
            //Convert a binary tree into a doubly link list
            var binaryTree = new BinaryTree(10);
            binaryTree.left = new BinaryTree(12);
            binaryTree.left.left = new BinaryTree(25);
            binaryTree.left.right = new BinaryTree(30);
            binaryTree.right = new BinaryTree(15);
            binaryTree.right.left = new BinaryTree(36);
            var convertBinaryTreeToDll = new ConvertBinaryTreeToDll();
            convertBinaryTreeToDll.MakeADLL(binaryTree);

            //Problem 4
            //Find LCA of a BST
            var lcaBinarySTree = new BinaryTree(20);
            lcaBinarySTree.left = new BinaryTree(8);
            lcaBinarySTree.left.left = new BinaryTree(4);
            lcaBinarySTree.left.right = new BinaryTree(12);
            lcaBinarySTree.left.right.left = new BinaryTree(10);
            lcaBinarySTree.left.right.right = new BinaryTree(14);
            lcaBinarySTree.right = new BinaryTree(22);
            var lcabst = new LCABST();
            lcabst.FindLCA(lcaBinarySTree, 10, 14);

            //Problem 5
            //Find LCA of a BT
            var lcaBinaryTree = new BinaryTree(1);
            lcaBinaryTree.left = new BinaryTree(2);
            lcaBinaryTree.left.left = new BinaryTree(4);
            lcaBinaryTree.left.right = new BinaryTree(5);
            lcaBinaryTree.right = new BinaryTree(3);
            lcaBinaryTree.right.left = new BinaryTree(6);
            lcaBinaryTree.right.right = new BinaryTree(7);
            var lcabt = new LCABT();
            lcabt.FindLCA(lcaBinaryTree, 4, 7);

            //Problem 6
            //Implement a special stack with GetMin() with operation of O(1)
            var stack = new Stack<int>();
            var secondStack = new Stack<int>();
            var getMinStack = new GetMinStack();
            getMinStack.PerformOperations(stack, secondStack);
            Console.ReadLine();
        }
    }
}
