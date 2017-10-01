using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions.Zillow
{
    public class Fibnonacci
    {
        public int[] results = new int[6];
        internal void PrintFibonacci()
        {
            Console.WriteLine();
            Console.WriteLine($"Problem 6: Print fib series.");
            PrintFib(5);
            foreach(var result in results)
            {
                Console.Write(result);
            }

        }

        private int PrintFib(int v)
        {
            if (v == 0 || v == 1)
            {
                results[v] = 1;
                return 1;
            }
            if (results[v] != 0)
                return results[v];
            else
                return results[v] = PrintFib(v - 1) + PrintFib(v - 2);
           
        }
    }
}
