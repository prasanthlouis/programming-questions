using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions.Microsoft
{
    class MicrosoftProblems
    {
        public MicrosoftProblems()
        {
            //------------- Microsoft ----------------//
            Console.WriteLine();
            Console.WriteLine("Microsoft's most asked questions");
            MicrosoftProblem1();
            MicrosoftProblem2();
            MicrosoftProblem3();
            MicrosoftProblem4();
            MicrosoftProblem5();
        }
        private static void MicrosoftProblem5()
        {
            throw new NotImplementedException();
        }

        private static void MicrosoftProblem4()
        {
            var printLastLines = new PrintLastNLine();
            printLastLines.PrintLastNLines();
        }

        private static void MicrosoftProblem3()
        {
            var sortedArray = new SearchForElementInRotatedArray();
            sortedArray.FindElementInRotatedArray();
        }

        private static void MicrosoftProblem2()
        {
            var removeString = new RemoveDuplicatesInAStringInPlace();
            removeString.RemoveDuplicates();
        }

        private static void MicrosoftProblem1()
        {
            //Problem 1
            //Check if a binary tree is BST or not
            var binaryTree = new BTisBinarySearchTreeOrNot();
            binaryTree.CheckIfItsBst();
        }
    }
}
