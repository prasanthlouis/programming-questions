public class Solution {
    public int NumIslands(char[,] grid) {
        
        var length = grid.GetLength(1);
        var height = grid.GetLength(0);
        var seen = new int[height,length];
        int count = 0;
        for(int i=0; i < height; i++)
        {
            for(int j =0; j < length;j++)
            {
                if(grid[i,j] == '1' && seen[i,j] == 0)
                {
                Recurse(grid, i,j, length, height, seen);
                count++;
                }
            }
        }
        return count;
    }
    
    public void Recurse(char[,] grid, int i, int j, int length, int height, int[,] seen)
    {
        if(i >= 0 && i < height && j >= 0 && j <length)
        {
        if(grid[i,j] == '1' && seen[i,j] == 0)
        {
        seen[i,j] = 1;
        Recurse(grid, i+1, j, length, height, seen);
        Recurse(grid, i-1, j, length, height, seen);
        Recurse(grid, i , j+1, length, height, seen);
        Recurse(grid, i, j-1, length, height, seen);
        }
        }
    }
}
