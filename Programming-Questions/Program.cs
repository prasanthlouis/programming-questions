using System;

namespace Programming_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find the k largest or smallest in an array
            var kLargest_SmallestInAnArray = new KLargest_SmallestInAnArray(new int[] { 3, 6, 7, 8, 4, 5, 2, 1, 0, 9 }, 5);
            kLargest_SmallestInAnArray.Solution();

            Console.ReadLine();
        }
    }
}
