public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        var dp = new bool[s.Length + 1];
        for(int i = 0 ; i <= s.Length; i++)
        {
            if(dp[i] == false && Containing(s.Substring(0,i), wordDict))
                dp[i] = true;
            
            if(dp[i] == true)
            {
                Console.WriteLine(i);
                for(int j = i+1 ; j <= s.Length; j++)
                {
                    if(dp[j] == false && Containing(s.Substring(i, j - i), wordDict))
                        dp[j] = true;
                    
                    if(dp[j] == true && j == s.Length)
                        return true;
                }
            }
        }
        
        return dp[s.Length];
    }
    
    public bool Containing(string str, IList<string> wordDict)
    {
        foreach(var word in wordDict)
        {
            if(str == word)
                return true;
        }
        return false;
    }
}
