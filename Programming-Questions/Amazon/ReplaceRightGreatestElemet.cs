using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions.Amazon
{
    public class ReplaceRightGreatestElemet
    {
        internal void ReplaceRightGreatest()
        {
            int[] input = new int[] { 16, 17, 4, 3, 5, 2 };
            var size = input.Length - 1;
            int max = input[size];
            input[size] = -1;
            for(int i = size - 1; i >= 0; i--)
            {
                var temp = input[i];
                input[i] = max;
                if (temp > max)
                    max = temp;
            }
            Console.WriteLine("\nProblem 10: Replace every element with greatest element on the right side");
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
