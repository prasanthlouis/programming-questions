using System;

namespace Programming_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            //Find the k largest or smallest in an array
            var kLargest_SmallestInAnArray = new KLargest_SmallestInAnArray(new int[] { 3, 6, 7, 8, 4, 5, 2, 1, 0, 9 }, 5);
            kLargest_SmallestInAnArray.Solution();
            Console.WriteLine();

            //Problem 2
            //Find a triplet. If found, print true else print false
            var triplet = new CheckForTriplet(new int[] { 5, 8, 9, 2, 4, 3 });
            triplet.Solution();
            Console.WriteLine();

            var noTriplet = new CheckForTriplet(new int[] { 5, 8, 9, 2, 4, 7 });
            noTriplet.Solution();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
