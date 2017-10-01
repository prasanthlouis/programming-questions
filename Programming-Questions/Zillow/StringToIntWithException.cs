using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions.Zillow
{
    public class StringToIntWithException
    {
        internal void Convert()
        {
            Console.WriteLine();
            Console.WriteLine($"Problem 8: Convert string to int with exception handling");
            string S = "12345";
            try
            {
                Console.Write(int.Parse(S));
            }
            catch (Exception ex)
            {
                Console.Write("Bad String");
            }
        }
    }
}
