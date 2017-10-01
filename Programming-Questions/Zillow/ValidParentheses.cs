using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions.Zillow
{
    public class ValidParentheses
    {
        internal void DoesItHaveValidP()
        {
            Console.WriteLine();
            Console.WriteLine($"Problem 3: Check if parentheses are balanced.");
            var stringToCheck = "[()]{}{[()()]()}";
            var stack = new Stack<char>();
            Console.WriteLine(DoesItHaveValidP(stringToCheck, stack));
        }

        private bool DoesItHaveValidP(string stringToCheck, Stack<char> stack)
        {
            foreach (var character in stringToCheck)
            {
                char lastCharacterInStack = 'x';
                if(stack.Count > 0)
                lastCharacterInStack = stack.Peek();
                if (stack.Count == 0)
                {
                    stack.Push(character);
                }
               else if(lastCharacterInStack == character)
                {
                    if (stack.Count > 1)
                    stack.Pop();
                    stack.Pop();
                }
                else
                {
                    stack.Push(character);
                }
            }
            if (stack.Count == 0)
                return true;
            else
                return false;
        }
    }
}
