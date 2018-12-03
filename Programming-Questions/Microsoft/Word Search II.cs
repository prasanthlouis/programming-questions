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
            Helper(board, count, i+1, j, burnBoard, word);
            Helper(board, count, i-1, j, burnBoard, word);
            Helper(board, count, i, j+1, burnBoard, word);
            Helper(board, count, i, j-1, burnBoard, word);
    }
    public void Helper(char[,] board, int count, int i, int j, bool[,] burnBoard, string word)
    {
      if(i < globalLength && j < globalHeight && i >= 0 && j>=0 && count < word.Length && board[i,j] == word[count] && !burnBoard[i,j])
      {
        count++;
        burnBoard[i,j] = true;
        Recurse(board, i, j, word, count, burnBoard);
        count--;
        burnBoard[i,j] = false;
      }
    }
}
