using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions.Amazon
{
    public class Subsequences
    {
        internal void FindNumberOfSubsequences()
        {
            var input = "abcabc";
            int a = 0;
            int b = 0;
            int c = 0;
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a')
                    a = 1 + (a * 2);
                else if (input[i] == 'b')
                    b = a + (b * 2);
                else if (input[i] == 'c')
                    c = b + (c * 2);
            }
            Console.WriteLine("\nSolution 9: Number of subsequences of the form a^ib^jc^k");
            Console.WriteLine(c);
        }
    }
}
