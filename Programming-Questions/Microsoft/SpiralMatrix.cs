public class Solution {
    public IList<int> SpiralOrder(int[,] matrix) {
        var list = new List<int>();
        var rows = matrix.GetLength(0) - 1;
        var columns = matrix.GetLength(1) - 1;
        int startingColumn = 0;
        int startingRow = 0;
        while(startingRow <= rows && startingColumn <= columns)
        {
            for(int j = startingColumn; j <= columns; j++)
            {
                list.Add(matrix[startingRow,j]);
            }
            
            startingRow++;
            
            
            for(int j = startingRow; j <= rows ; j++)
            {
                list.Add(matrix[j, columns]);
            }
            
            columns--;
            
            if(startingRow <= rows)
            {
            for(int j = columns ; j >= startingColumn ; j--)
            {
                list.Add(matrix[rows, j]);
            }
            rows--;
                
            }
            
            if(startingColumn <= columns)
            {
            for(int j = rows; j >= startingRow; j--)
            {

                list.Add(matrix[j, startingColumn]);
            }
            startingColumn++;
            }
        }
        return list;
    }
}
