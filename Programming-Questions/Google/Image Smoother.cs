public class Solution {
    public int[,] ImageSmoother(int[,] M) {
        var noOfRows = M.GetLength(0);
        var noOfColumns = M.GetLength(1);
        var X = new int[noOfRows,noOfColumns];
        for(int i = 0 ; i < noOfRows; i++)
        {
            for(int j = 0 ; j < noOfColumns; j++)
            {
                X[i,j] = M[i,j];
            }
        }
        //Console.WriteLine($"{noOfRows} {noOfColumns}");
        for(int i = 0 ; i < noOfRows; i++)
        {
            for(int j = 0 ; j < noOfColumns ; j++)
            {
                var points = DeterminePoints(i, j, M, noOfRows, noOfColumns);
                X[i,j] = (int)points;
            }
        }
        return X;
    }
    
    public double DeterminePoints(int i, int j, int[,] M, int noOfRows, int noOfColumns)
    {
        var totalCounter = 0;
        var validCounter = 0;
        //if(i== 1 && j == 0)
        //Console.WriteLine(M[i,j]);
        for(int x = Math.Max(0, i - 1); x <= Math.Min(i+1, noOfRows - 1); x++)
        {
            for(int y = Math.Max(0,j - 1) ; y <=Math.Min(j+1, noOfColumns - 1) ; y++)
            {
                validCounter += M[x,y]; 
                totalCounter++;
            }
        }
        //Console.WriteLine($"{validCounter} {totalCounter}");
        return Math.Floor((double)(validCounter/totalCounter));
    }
}

