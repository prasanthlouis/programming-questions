using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions.Amazon
{
    public class PossiblePathMatrix
    {
        internal void FindPossiblePaths()
        {
            //I'm doing a 3 by 3
            var matrix = new int[3,3];
            for (int i = 0; i < 3; i++)
                matrix[i,0] = 1;
            for (int i = 0; i < 3; i++)
                matrix[0,i] = 1;
            for(int i = 1; i < 3; i++)
            {
                for(int j = 1; j < 3; j++)
                {
                    matrix[i,j] = matrix[i - 1,j] + matrix[i,j - 1];
                }
            }
            Console.WriteLine("\nSolution 12: Count all possible paths from top left to bottom right of a mXn matrix");
            Console.WriteLine(matrix[2,2]);
        }
    }
}
