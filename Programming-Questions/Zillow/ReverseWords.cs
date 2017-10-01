using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions.Zillow
{
    class ReverseWords
    {
        internal void ReverseThisSentence()
        {
            Console.WriteLine($"Problem 1: Reverse a sentence");
            var sentence = "This is a sentence. Please reverse it";
            var splittedSentence = sentence.Split(' ');
            for(int i = splittedSentence.Length - 1; i >= 0; i--)
            {
                Console.Write(splittedSentence[i] + ' ');
            }
            Console.WriteLine();
        }
    }
}
