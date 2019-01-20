public class Solution {
    public int NumDecodings(string s) {
        var dp = new int[s.Length + 1];

        dp[s.Length] = 1;
        dp[s.Length - 1] = s[s.Length -1] == '0' ? 0 : 1;
        for(int i = s.Length - 2 ; i >= 0 ; i--)
        {
            if(s[i] == '0')
                continue;
            var element = int.Parse(s.Substring(i,2));
            if(element == 0)
                continue;
            else if(element <= 26)
            {
                dp[i] = dp[i+1] + dp[i+2];
                
            }
            else{
                dp[i] = dp[i+1];
            }
            
        }

        return dp[0];
    }
}
