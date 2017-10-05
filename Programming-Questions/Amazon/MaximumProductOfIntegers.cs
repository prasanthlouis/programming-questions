using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions.Amazon
{
    public class MaximumProductOfIntegers
    {
        internal void FindMaximumProduct()
        {
            var integers = new int[] { -1, -3, -4, 2, 0, -5 };
            FindMaximumProduct(integers);
        }

        private void FindMaximumProduct(int[] integers)
        {
            int maximumPositiveInteger = int.MinValue;
            int secondMaxPositiveInteger = int.MinValue;
            int maximumNegativeInteger = int.MaxValue;
            int secondMaxNegativeInteger = int.MaxValue ;
            for(int i = 0; i < integers.Length; i++)
            {
                if(integers[i] > 0 && integers[i] > maximumPositiveInteger)
                {
                    secondMaxPositiveInteger = maximumPositiveInteger;
                    maximumPositiveInteger = integers[i];
                }
                else if(integers[i] > 0 &&  integers[i] > secondMaxPositiveInteger)
                {
                    secondMaxPositiveInteger = integers[i];
                }
                if(integers[i] < 0 && integers[i] < maximumNegativeInteger)
                {
                    secondMaxNegativeInteger = maximumNegativeInteger;
                    maximumNegativeInteger = integers[i];
                }
                else if(integers[i] < 0 && integers[i] < secondMaxNegativeInteger)
                {
                    secondMaxNegativeInteger = integers[i];
                }
            }

            Console.WriteLine("\nSolution 13: Find a pair with maximum product in array of Integers");
            if (maximumPositiveInteger * secondMaxPositiveInteger > maximumNegativeInteger * secondMaxNegativeInteger)
            {
                Console.WriteLine($"{{{maximumPositiveInteger},{secondMaxPositiveInteger}}}");
            }
            else
                Console.WriteLine($"{{{maximumNegativeInteger},{secondMaxNegativeInteger}}}");
        }
    }
}
