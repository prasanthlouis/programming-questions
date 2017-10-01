using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions.Zillow
{
    public class ReverseANumber
    {
        internal void Reverse()
        {
            Console.WriteLine();
            Console.WriteLine($"Problem 5: Reverse a number");
            int number = 321;
            int sum = 0;
            int count = number.ToString().Length;
            while(number > 0)
            {
                int remainder = number % 10;
                sum = sum + ((int)Math.Pow(10,count-1) * remainder);
                count--;
                number = number / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
