public class Solution {
    public int NumDecodings(string s) {
        var dp = new int[s.Length + 1];
        if(s == null || s.Length == 0) {
            return 0;
        }
        dp[0] = 1;
        dp[1] = s[0] == '0' ? 0 : 1;
        for(int i = 2 ; i <= s.Length ; i++)
        {
            var element =  int.Parse(s.Substring(i-1,1));
            var secondElement = int.Parse(s.Substring(i-2,2));

            if(element > 0)
            {
                dp[i] += dp[i-1];           
            }
            if(secondElement >= 10 && secondElement <= 26){
                dp[i] += dp[i-2];
            }
            
        }

        return dp[s.Length];
    }
}

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
