using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions.Zillow
{
    public class ZillowProblems
    {
        public ZillowProblems()
        {
            //------------- Zillow ----------------//
            Console.WriteLine();
            Console.WriteLine("Zillow's most asked questions");
            ZillowProblem1();
            ZillowProblem2();
            ZillowProblem3();
            ZillowProblem4();
        }

        private void ZillowProblem4()
        {
            var lcabst = new FindLCAOfBinaryTree();
            lcabst.FindLowestCA();
        }

        private void ZillowProblem3()
        {
            var validP = new ValidParentheses();
            validP.DoesItHaveValidP();
        }

        private void ZillowProblem2()
        {
            var rootToLeafSum = new RootToLeafSum();
            rootToLeafSum.SeeIfTheresAPath();
        }

        private void ZillowProblem1()
        {
            var reverseWordsInASentence = new ReverseWords();
            reverseWordsInASentence.ReverseThisSentence();
        }
    }
}
