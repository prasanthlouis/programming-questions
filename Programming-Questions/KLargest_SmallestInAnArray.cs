using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions
{
    public class KLargest_SmallestInAnArray
    {
        private int[] _numbers;
        private int _limit;
    public KLargest_SmallestInAnArray(int[] numbers, int limit)
    {
            _numbers = numbers;
            _limit = limit;
    }

        internal void Solution()
        {
            Console.WriteLine("Solution 1:");
             Array.Sort(_numbers);
            for(int i = 0; i < _limit; i++)
            {
                Console.Write(_numbers[i]);
            };
        }
    }
}
