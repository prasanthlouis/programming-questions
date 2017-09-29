using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions.Microsoft
{
    public class RemoveDuplicatesInAStringInPlace
    {
        internal void RemoveDuplicates()
        {
            RemoveDuplicateLetters("geeksforgeeks");
        }

        private void RemoveDuplicateLetters(string intputString)
        {
            var hashMap = new HashSet<char>();
            foreach(var character in intputString)
            {
                hashMap.Add(character);
            }

            Console.WriteLine();
            Console.WriteLine($"Problem 2: Remove duplicates in a string");
            foreach (var character in hashMap)
            {
                Console.Write(character);
            }
            Console.WriteLine();
        }
    }
}
