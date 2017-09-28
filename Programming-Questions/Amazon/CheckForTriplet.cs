using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions
{
    public class CheckForTriplet
    {
        private int[] _numbers;
        public CheckForTriplet(int[] numbers)
        {
            _numbers = numbers;
        }
        internal void Solution()
        {
            Console.WriteLine("Solution 2: Find a triplet. If found, print true else print false");
            if (CheckForTriplets(_numbers, _numbers.Length))
            {
                Console.WriteLine("We found a triplet!");
            }
            else
                Console.WriteLine("We couldn't find a triplet.");
        }

        internal bool CheckForTriplets(int[] numbers, int length)
        {
            for (int i = 0; i < length; i++)
                numbers[i] = numbers[i] * numbers[i];

            Array.Sort(numbers);
            for(int i = length-1; i >= 2; i--)
            {
                int l = 0;
                int r = i;
                int hypotenuse = numbers[i];
                while (l < r)
                {
                    int firstSide = numbers[l];
                    int secondSide = numbers[i - 1];
                    if (firstSide + secondSide == hypotenuse)
                        return true;

                    else if (firstSide + secondSide < hypotenuse)
                        l++;

                    else
                        r--;
                }
            }
                return false;
        }
    }
}
