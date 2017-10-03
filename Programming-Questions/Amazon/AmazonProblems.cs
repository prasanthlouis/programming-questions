using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions.Amazon
{
    public class AmazonProblems
    {
        public AmazonProblems()
        {
            //------------- Amazon ----------------//
            Console.WriteLine("Amazon's most asked questions");
            AmazonProblem1();
            AmazonProblem2();
            AmazonProblem3();
            AmazonProblem4();
            AmazonProblem5();
            AmazonProblem6();
            AmazonProblem7();
            AmazonProblem8();
            AmazonProblem9();
            AmazonProblem10();
        }

        private void AmazonProblem10()
        {
            //Problem 10
            //Replace every element with greatest element on the right side
            var element = new ReplaceRightGreatestElemet();
            element.ReplaceRightGreatest();
        }

        private void AmazonProblem9()
        {
            //Problem 9
            //Number of subsequences of the form a^ib^jc^k
            var subs = new Subsequences();
            subs.FindNumberOfSubsequences();
        }

        private static void AmazonProblem8()
        {
            //Problem 8
            //Count total set bits in all numbers from 1 to n
            var setbits = new TotalSetBits1toN();
            setbits.CountTotalSetBits();
        }

        private static void AmazonProblem7()
        {
            //Problem 7
            //Implement reversing a link list in groups of (k)
            var reverseLinkList = new LinkList();
            reverseLinkList.ReverseLinkListInGroupsOfKS();

        }

        private static void AmazonProblem6()
        {
            //Problem 6
            //Implement a special stack with GetMin() with operation of O(1)
            var stack = new Stack<int>();
            var secondStack = new Stack<int>();
            var getMinStack = new GetMinStack();
            getMinStack.PerformOperations(stack, secondStack);
        }

        private static void AmazonProblem5()
        {
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
        }

        private static void AmazonProblem4()
        {
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
        }

        private static void AmazonProblem3()
        {
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
        }

        private static void AmazonProblem2()
        {
            //Problem 2
            //Find a triplet. If found, print true else print false
            var triplet = new CheckForTriplet(new int[] { 5, 8, 9, 2, 4, 3 });
            triplet.Solution();
            Console.WriteLine();
        }

        private static void AmazonProblem1()
        {
            //Problem 1
            //Find the k largest or smallest in an array
            var kLargest_SmallestInAnArray = new KLargest_SmallestInAnArray(new int[] { 3, 6, 7, 8, 4, 5, 2, 1, 0, 9 }, 5);
            kLargest_SmallestInAnArray.Solution();
            Console.WriteLine();
        }
    }
}
