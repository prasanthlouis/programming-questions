public class Solution {
    public bool SearchMatrix(int[,] matrix, int target) {
        var noOfRows = matrix.GetLength(0);
        var noOfColumns = matrix.GetLength(1);
        if(noOfRows == noOfColumns && noOfRows == 1)
            return matrix[0,0] == target;
        if(noOfColumns == 0)
            return false;
        int i = 0;
        for(; i < noOfRows ; i++)
        {
            if(matrix[i,0] == target)
                return true;
            if(matrix[i,0] > target)
            {
                Console.WriteLine($"{matrix[i,0]}");
                break;
            }
        }
        i--;
        if(i >= 0)
        {
        for(int j = 0; j < noOfColumns;j++)
        {
            if(matrix[i,j] == target)
                return true;
        }
        }
        return false;
    }
}
