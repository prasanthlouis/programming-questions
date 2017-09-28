using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions
{
    public class GetMinStack
    {
        internal void PerformOperations(Stack<int> stack, Stack<int> secondStack)
        {
            Console.WriteLine("\nSolution 6: Implement a special stack to getMinimum of operation O(1)");
            SetUpStack(stack, secondStack);
            GetMinimum(stack, secondStack);
            PopStack(stack, secondStack);
            PopStack(stack, secondStack);
            PopStack(stack, secondStack);
            GetMinimum(stack, secondStack);
        }

        private void PopStack(Stack<int> stack, Stack<int> secondStack)
        {
            stack.Pop();
            secondStack.Pop();
        }

        private void GetMinimum(Stack<int> stack, Stack<int> secondStack)
        {
            Console.WriteLine(secondStack.Peek());
        }

        //Pushing elements into stack
        private void SetUpStack(Stack<int> stack, Stack<int> secondStack)
        {
            var numbers = new int[] { 3, 7, 4, 9, 1, 6, 8 };
            foreach(var number in numbers)
            {
                if (secondStack.Count > 0)
                {
                    var topOfSecondStack = secondStack.Peek();
                    if (number < topOfSecondStack)
                        secondStack.Push(number);
                    else
                        secondStack.Push(topOfSecondStack);
                }
                else
                {
                    secondStack.Push(number);
                }
                stack.Push(number);
            }
        }
    }
}
