using System.Text.RegularExpressions;
public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        if(string.IsNullOrWhiteSpace(s))
            return true;
        var regex = new Regex("[^a-z0-9]");
        s=  regex.Replace(s, string.Empty);
        int j =s.Length - 1;
        for(int i = 0 ; i < s.Length/2 ; i++)
        {
            if(s[i] != s[j])
                return false;
            j--;
            
        }
        return true;
    }
}
