public class Solution {
    public List<int> SpiralOrder(int[,] matrix) {
        var rows = matrix.GetLength(0);
        var columns = matrix.GetLength(1);
        var answer = new List<int>();
        var r = 0;
        var c = 0;
        while(r < rows && c < columns)
        {
            for(int i = c; i < columns ; i++)
            {
                answer.Add(matrix[r,i]);
            }
            
            r++;
            
            for(int i = r; i < rows ; i++)
            {
                answer.Add(matrix[i, columns - 1]);
            }
            
            columns--;
            if(r < rows)
            {
                for(int i = columns - 1 ; i >= c ; i--)
                {
                    answer.Add(matrix[rows - 1, i]);
                }
                            rows--;
            }
            
            if(c < columns)
            {
                for(int i = rows - 1 ; i >= r ; i--)
                {
                    answer.Add(matrix[i, c]);
                }
                c++;
            }
        }
        return answer;
    }
}
