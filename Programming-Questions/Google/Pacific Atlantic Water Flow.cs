public class Solution {
    public List<int[]> PacificAtlantic(int[,] matrix) {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        
        if(rows == 0 || columns == 0)
            return new List<int[]>();
        if(rows == 1 && columns == 1)
            return new List<int[]>(){new int[2]{0,0}};
        
        List<int[]> answer = new List<int[]>();

        for(int i = 0 ; i < rows; i++)
        {
            for(int j = 0 ; j < columns; j++)
            {
                var visited = new bool[rows,columns];
                var isValidPath = Recurse(matrix, i, j, rows, columns, visited);
                if(isValidPath.Atlantic && isValidPath.Pacific)
                {
                    var comb = new int[2]{i,j};
                    answer.Add(comb);
                }
            }
        }
        
        return answer;
    }
    
    public Oceans Recurse(int[,] matrix, int i, int j, int rows, int columns, bool[,] visited)
    {
        var ocean = new Oceans();
        var ocean1 = new Oceans();
        var ocean2 = new Oceans();
        var ocean3 = new Oceans();
        var ocean4 = new Oceans();
        
        if((i == 0) || (j == 0))
            ocean.Pacific = true;
        
        if((i == rows - 1) || (j == columns - 1))
            ocean.Atlantic = true;
        
        if(ocean.Pacific && ocean.Atlantic)
            return ocean;
        
        if(visited[i,j])
            return ocean;
        
        visited[i,j] = true;
        
        
         if(i + 1 < rows && matrix[i+1,j ] <= matrix[i,j])
            ocean1 = Recurse(matrix, i + 1, j, rows, columns, visited);
         if(i - 1 >= 0 && matrix[i-1,j ] <= matrix[i,j])
            ocean2 = Recurse(matrix, i - 1, j, rows, columns, visited);
         if(j + 1 < columns && matrix[i,j + 1 ] <= matrix[i,j])
             ocean3 =Recurse(matrix, i, j + 1, rows, columns, visited);
         if(j - 1 >= 0 && matrix[i,j - 1 ] <= matrix[i,j])
            ocean4 =Recurse(matrix, i, j - 1, rows, columns, visited); 
        
        if(ocean1.Pacific || ocean2.Pacific || ocean3.Pacific ||ocean4.Pacific || ocean.Pacific)
            ocean.Pacific = true;
        if(ocean1.Atlantic || ocean2.Atlantic || ocean3.Atlantic ||ocean4.Atlantic || ocean.Atlantic)
            ocean.Atlantic = true;
        
        return ocean;
        
    }
    
    public class Oceans{
        public bool Pacific{get;set;}
        public bool Atlantic{get;set;}
    }
}
