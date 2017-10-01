using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions.Zillow
{
    public class BlackJack
    {
        internal void Calculate()
        {
            Console.WriteLine();
            Console.WriteLine($"Problem 7: Let's play some BlackJack!");
            Console.WriteLine();
            char[] cards = new char[] { 'A','2' };
            char[] cardsThatHaveBeenPlayed = new char[cards.Length];
            int sum = 0;
            int counter = 0;
            foreach(var character in cards)
            {
                cardsThatHaveBeenPlayed[counter++] = character;
                if (character == 'A')
                    if (sum + 10 <= 21)
                        sum += 10;
                    else
                        sum += 1;
                else if(int.TryParse(character.ToString(), out int num))
                {
                    sum += num;
                }
                else
                {
                    sum += 10;
                }
                if (sum == 21)
                    Console.WriteLine("BlackJack!");
                else if (sum > 21)
                {
                    int i = 0;
                    foreach (var x in cardsThatHaveBeenPlayed)
                    {
                        int sumCopy = sum;
                        if (x == 'A')
                        {
                            sumCopy -= 9;
                            cardsThatHaveBeenPlayed[i] = 'X';
                        }
                        i++;
                        if(sumCopy == 21)
                        {
                            Console.WriteLine("BlackJack!");
                            sum = sumCopy;
                            break;
                        }
                        if (Math.Abs(sumCopy - 21) < Math.Abs(sum - 21))
                            sum = Math.Abs(sumCopy - 21);
                    }

                    if (sum > 21)
                    {
                        Console.WriteLine("Bust");
                        break;
                    }
                }
                if (sum == 21)
                    break;
                    
            }
            Console.WriteLine(sum);
        }
    }
}
