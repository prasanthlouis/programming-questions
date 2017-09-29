using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions.Microsoft
{
    public class SearchForElementInRotatedArray
    {
        internal void FindElementInRotatedArray()
        {
            var array = new int[] { 3, 4, 5, 1, 2 };
            Console.WriteLine();
            Console.WriteLine($"Problem 3: Find element in rotated array");
            Console.WriteLine(FindElementInRotatedArrays(array,0, array.Length - 1, 1));
        }

        private int FindElementInRotatedArrays(int[] array, int low, int high, int v)
        {
            if (low > high)
                return -1;

            int middle = (low + high) / 2;
            if (array[middle] == v)
                return middle;

           if(array[low] <= array[middle])
            {
                if (v >= array[low] && v <= array[middle])
                    return FindElementInRotatedArrays(array, low, middle, v);
                else
                    return FindElementInRotatedArrays(array, middle + 1, high, v);
            }
           if(v >= array[middle] && v <= array[high])
            {
                return FindElementInRotatedArrays(array, middle, high, v);
            }
                return FindElementInRotatedArrays(array, middle - 1, high, v);
        }
    }
}
