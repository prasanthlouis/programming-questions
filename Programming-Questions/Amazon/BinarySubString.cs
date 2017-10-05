using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions.Amazon
{
    public class BinarySubString
    {
        internal void CountNumberOfStrings()
        {
            var binaryString = "00100101";
            int count = 0;
            for(int i = 0; i < binaryString.Length; i++)
            {
                if (binaryString[i] == '1')
                    count++;
            }
            Console.WriteLine("\nSolution 14: Given a binary string, count number of substrings that start and end with 1");
            Console.WriteLine((count * (count - 1)) / 2);
        }
    }
}
