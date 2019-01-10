public class Solution {
    public int[] FindDiagonalOrder(int[,] matrix) {
        var rows = matrix.GetLength(0);
        var columns = matrix.GetLength(1);  
        if(rows == 0 && columns == 0)
            return new int[0];
        if(rows == 1 && columns == 1)
            return new int[1] {matrix[0,0]};
        int[] result = new int[rows * columns];
        int counter = 0;
        int row = 0;
        int column = 0;
        while(counter != (rows * columns))
        {   

            while(column < columns && row >= 0)
            {    
                result[counter++] = matrix[row--, column++];
            }
            
            row = row + 1;
                if(column == columns)
            {
                row++;
            }
            column = column == columns ? column - 1 : column;
            if(counter == (rows * columns))
                break;
            while(row < rows && column >= 0)
            {
                result[counter++] = matrix[row++, column--];
            }

            column = column + 1;
            if(row == rows)
                column++;
            row = row == rows ? row - 1 : row;
        }
        return result;
    }
}
