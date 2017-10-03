using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions.Amazon
{
    public class HighestPowerOf2
    {
        public void FindHighestPowerOf2()
        {
            int n = 19;
            TryHighest(19);
        }

        private void TryHighest(int v)
        {
            int current = 0;
            int answer = 0;
            for(int i = 0;i < 32; i++)
            {
                current = 1 << i;
                if (current > v)
                    break;
                answer = current;
            }

            Console.WriteLine("\nSolution 11: Highest power of 2 less than or equal to given number");
            Console.WriteLine(answer);
        }
    }
}
