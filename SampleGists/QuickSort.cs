using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new int[10] {-3,4,10,312,3,6,12, 4, 2, 5 };
            int low = 0;
            int high = numbers.Count() - 1;
            Recurse(numbers, low, high);
            for(int i = 0; i < numbers.Count(); i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();
        }

        private static void Recurse(int[] numbers, int low, int high)
        {
            if(low < high)
            {
                var index = Partition(numbers, low, high);
                Recurse(numbers, low, index - 1);
                Recurse(numbers, index + 1, high);
            }
        }

        private static int Partition(int[] numbers, int low, int high)
        {
            var pivot = numbers[high];

            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if(numbers[j] <= pivot)
                {
                    i++;
                    var temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }

            var tempy = numbers[i + 1];
            numbers[i + 1] = numbers[high];
            numbers[high] = tempy;

            return i + 1;
        }
    }
}
