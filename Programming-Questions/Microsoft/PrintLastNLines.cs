  using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Programming_Questions.Microsoft
{
    public class PrintLastNLine
    {
        internal void PrintLastNLines()
        {
            Console.WriteLine();
            Console.WriteLine($"Problem 4: Print last N lines of a file");
            var lines = "str1\nstr2\nstr3\nstr4\nstr5\nstr6\nstr7\nstr8\nstr9\nstr10\nstr11\nstr12\nstr13\nstr14\nstr15\nstr16\nstr17\nstr18\nstr19\nstr20\nstr21\nstr22\nstr23\nstr24\nstr25";
            var regex = Regex.Match(lines, "^.*$", RegexOptions.Multiline | RegexOptions.RightToLeft);
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(regex.Value);
                regex = regex.NextMatch();

            }
        }
    }
}
