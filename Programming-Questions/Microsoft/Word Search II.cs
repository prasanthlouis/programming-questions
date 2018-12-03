public class Solution {
    List<string> answerList = new List<string>();
    int globalLength = 0;
    int globalHeight = 0;
    public IList<string> FindWords(char[,] board, string[] words) {
        var length = board.GetLength(0);
        var height = board.GetLength(1);
        globalLength = length;
        globalHeight = height;
        for(int i = 0; i < length; i++)
        {
            for(int j = 0 ; j < height; j++)
            {
                for(int k = 0; k < words.Count(); k++)
                {
                    if(board[i,j] == words[k][0])
                    {
                        var burnBoard = new bool[length,height];
                        burnBoard[i,j] = true;
                        Recurse(board,i,j, words[k], 1, burnBoard);
                    }
                }
            }
        }
        answerList =  answerList.Distinct().ToList();
        return answerList.ToList();
    }
    
    public void Recurse(char[,] board, int i, int j, string word, int count, bool[,] burnBoard)
    {

        if(count == word.Length)
        {
            answerList.Add(word);
            return;
        }
        if(i+1 < globalLength && count < word.Length && board[i+1,j] == word[count] && !burnBoard[i+1,j])
        {
            count++;
            burnBoard[i+1,j] = true;
            Recurse(board, i+1, j, word, count, burnBoard);
            count--;
            burnBoard[i+1,j] = false;
        }
         if(i-1 >= 0 && count < word.Length && board[i-1, j] == word[count] && !burnBoard[i-1,j])
        {
            count++;
            burnBoard[i-1,j] = true;
            Recurse(board, i-1, j, word, count,burnBoard);
             count--;
                 burnBoard[i-1,j] = false;
        }
         if(j+1 < globalHeight && count < word.Length && board[i, j+1] == word[count] && !burnBoard[i,j+1])
        {
            count++;
            burnBoard[i,j+1] = true;
            Recurse(board, i, j+1, word, count,burnBoard);
             count--;
                 burnBoard[i,j+1] = false;
        }
         if(j-1 >= 0 && count < word.Length &&  board[i, j-1] == word[count] && !burnBoard[i,j-1])
        {
            count++;
            burnBoard[i,j-1] = true;
            Recurse(board, i, j-1, word, count,burnBoard);
             count--;
                 burnBoard[i,j-1] = false;
        }
    }
}
