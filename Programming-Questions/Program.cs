using System;

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
            var lcaBinaryTree = new BinaryTree(20);
            lcaBinaryTree.left = new BinaryTree(8);
            lcaBinaryTree.left.left = new BinaryTree(4);
            lcaBinaryTree.left.right = new BinaryTree(12);
            lcaBinaryTree.left.right.left = new BinaryTree(10);
            lcaBinaryTree.left.right.right = new BinaryTree(14);
            lcaBinaryTree.right = new BinaryTree(22);
            var lcabst = new LCABST();
            lcabst.FindLCA(lcaBinaryTree, 10, 14);

            Console.ReadLine();
        }
    }
}
