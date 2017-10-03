using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions.Amazon
{
    public class TotalSetBits1toN
    {
        internal void CountTotalSetBits()
        {
            int n = 8;
            CountTotalBits(n);
        }

        private void CountTotalBits(int n)
        {
            int bitCounter = 0;
            for(int i = 1; i <= n;i ++)
            {
                bitCounter += FindBitCounter(i);
            }
            Console.WriteLine("\nSolution 8: Count total set bits in all numbers from 1 to n");
            Console.WriteLine(bitCounter);
        }

        private int FindBitCounter(int n)
        {
            if (n <= 0)
                return 0;
            return (n % 2 == 0 ? 0 : 1) + FindBitCounter(n / 2);
        }
    }
}
