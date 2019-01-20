public class Solution {
    public int WordsTyping(string[] sentence, int rows, int cols) {
        var dp = new int[sentence.Count()];
        var len = 0;
        var k = 0;
        var n = sentence.Count();
        int c = 0;
        for(int i = 0; i < sentence.Count(); i++){
            if(i > 0)
            {
                len -= sentence[i-1].Length + 1;
            }
            while((len + sentence[k % n].Length) <= cols)
            {
                len += sentence[k++ % n].Length + 1;
            }

            dp[i] = k;
        }
        for(int i = 0 ; i < dp.Count(); i++)
        {
            Console.WriteLine(dp[i]);
        }
        int count = 0;
        int l = 0;
        for(int i = 0 ; i < rows; i++)
        {
            count += dp[l];
            l = dp[l];
        }
        
        return count / n;
    }
}
