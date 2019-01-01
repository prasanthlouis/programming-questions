//Second Solution

public class Solution {
    
    public void GameOfLife(int[][] board) {
        int length = board.GetLength(0);
        int columns = board[0].GetLength(0);
        for(int i = 0 ; i < length ; i++)
        {
            for(int j = 0 ; j < columns ; j++)
            {
               int lives = CountNumberOfLives(board, i, j, length, columns); 
               //Console.WriteLine(lives);
               if(board[i][j] == 1 && (lives == 2 || lives == 3))
               {
                   board[i][j] = 3;
               }
                else if(board[i][j] == 0 && lives ==3)
                {
                    board[i][j] = 2;
                }
                
            }
        }
        for(int i = 0; i < length; i++)
        {
            for(int j =0 ; j < columns ; j++)
            {
                board[i][j] = board[i][j] >> 1;
            }
        }
    }
    
    public int CountNumberOfLives(int[][]board, int i, int j, int length, int columns)
    {
        int lives = 0;
        //Console.WriteLine($"{board[i][j]} ele");
        for(int k = Math.Max(i-1, 0) ; k <= Math.Min(i+1, length - 1 ); k++)
        {
            for(int l = Math.Max(j-1, 0) ; l <= Math.Min(j+1, columns - 1) ; l++)
            {
                //Console.WriteLine(board[k][l]);
                lives += board[k][l] & 1;
            }
        }
        lives -= board[i][j] & 1;
            return lives;
    }
}

public class Solution {
    
    public void GameOfLife(int[][] board) {
        var length = board.GetLength(0);
        var height = board[0].GetLength(0);
        var newBoard = new int[length][];
        for(int i = 0 ; i < length ; i++)
        {
                newBoard[i] = new int[height];
            
            for(int j = 0 ; j < height ; j++)
            {
                newBoard[i][j] = board[i][j];
            }
        }
        
        for(int i = 0 ; i < board.GetLength(0) ; i++)
        {
            for(int j = 0; j < board[0].GetLength(0) ; j++)
            {
                
                int topLeft = 0;
                int top =0;
                int topRight = 0;
                int left = 0;
                int right = 0;
                int bottomLeft = 0;
                int bottomRight = 0;
                int bottom = 0;
                
                //Console.WriteLine($"{board[i][j]} ele");
                var element = board[i][j];
                if(i-1 >= 0)
                {
                   // Console.WriteLine("HI");
                    top = board[i-1][j];
                    if(j-1 >= 0)
                    {
                        topLeft = board[i-1][j-1];
//Console.WriteLine($"topLeft {topLeft}");
                        
                    }
                    if(j+1 < board[0].GetLength(0))
                    {
                        
                        topRight = board[i-1][j+1];   
                         // Console.WriteLine($"topRight {topRight}");
                    }
                }
                if(j-1 >= 0)
                {
                    //Console.WriteLine($"Bye {i} {j-1}");
                    //Console.WriteLine(board[i][j-1]);
                    left = board[i][j-1];
                    //Console.WriteLine($"Left {left}");
                    if(i+1 < board.GetLength(0))
                    {
                        bottomLeft = board[i+1][j-1];
                        //Console.WriteLine($"bottomLeft {bottomLeft}");
                    }
                }
                if(j+1 < board[0].GetLength(0))
                {
                    right = board[i][j+1];
                    //Console.WriteLine($"RIght {right}");
                }
                
                if(i+1 < board.GetLength(0))
                {
                    
                    bottom = board[i+1][j];
                    //Console.WriteLine($"bottom {bottom}");
                    
                    if(j + 1 < board[0].GetLength(0))
                    {
                        bottomRight = board[i+1][j+1];
                    //Console.WriteLine($"bottomRight {bottomRight}");
                        
                    }
                        
                }
                var sum = topLeft + topRight + top + bottomLeft + bottomRight + bottom + left + right;
                //Console.WriteLine(sum);
                if(element == 1  && sum < 2)
                    newBoard[i][j] = 0;
                if(element == 1  && (sum == 2 || sum == 3))
                    newBoard[i][j] = 1;
                if(element == 1  && sum > 3)
                    newBoard[i][j] = 0;
                if(element == 0 && sum == 3)
                    newBoard[i][j] = 1;
                
            }
        }
        for(int i = 0 ; i < board.GetLength(0); i++)
        {
            for(int j = 0 ; j < board[0].GetLength(0) ; j++)
            {
                board[i][j] = newBoard[i][j];
            }
        }
    }
}
