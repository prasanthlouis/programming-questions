public class Solution {
    int[,] dp = new int[1,1];
    public int MinPathSum(int[,] grid) {
        var rows = grid.GetLength(0);
        var columns = grid.GetLength(1);
        var test = new int[rows,columns];
                dp = test;


        Recurse(grid, 0, 0, 0);
        return dp[rows-1, columns-1];
    }
    
    public void Recurse(int[,] grid, int i, int j, int prevSum)
    {
        
        if(i >= grid.GetLength(0) || j >= grid.GetLength(1))
            return;
        
        var sum = grid[i,j] + prevSum;
        if(sum < dp[i,j] || dp[i,j] == 0)
        {
            dp[i,j] = sum;
        }
        else{
            return;
        }
        
        Recurse(grid, i + 1, j, sum);
        
        Recurse(grid, i, j + 1, sum);
    }
}
