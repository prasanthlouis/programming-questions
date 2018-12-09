public class Solution {
    int MaximumLength = 0;
    int index = 0;
    public string LongestPalindrome(string s) {
       if(s.Length < 2)
           return s;
        
        for(int i = 0; i< s.Length -1 ; i++)
        {
            Reversing(s, i, i);
            Reversing(s, i, i+1);
        }
       return s.Substring(index, MaximumLength);
    }
    
    public void Reversing(string s, int i, int j)
    {
        while(i >= 0 && j < s.Count() && s[i] == s[j])
        {
            j++;
            i--;
        }
        if(j-i-1 > MaximumLength)
        {
            index = i+1;
            MaximumLength = j-i-1;
        }
    }
}
