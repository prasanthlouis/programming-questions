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
                var mid = (low + high) / 2;
                Recurse(numbers, low, mid);
                Recurse(numbers, mid + 1, high);

                Merge(numbers, low, mid, high);
            }

        }

        private static int[] Merge(int[] numbers, int low, int mid, int high)
        {
            var length = mid - low + 1;
            var length2 = high - mid;
            var first = new int[length];
            var second = new int[length2];
            int i = 0;
            int j = 0;
            for(i = 0; i < length; i++)
            {
                first[i] = numbers[low + i];
            }
            for(j = 0; j < length2; j++)
            {
                second[j] = numbers[mid + 1 + j];
            }
            i = 0;
            j = 0;
            int k = low;
            while(i < length && j < length2)
            {
              if(first[i] < second[j])
                {
                    numbers[k++] = first[i];
                    i++;
                }
                else
                {
                    numbers[k++] = second[j];
                    j++;
                }
            }

            while(i < length)
            {
                numbers[k++] = first[i++];
            }

            while(j < length2)
            {
                numbers[k++] = second[j++];
            }

            return numbers;

        }
    }
}
