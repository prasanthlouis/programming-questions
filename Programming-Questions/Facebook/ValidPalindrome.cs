using System.Text.RegularExpressions;
public class Solution {
    public bool IsPalindrome(string s) {
        var regex = new Regex("[^0-9a-zA-Z]");
         s = regex.Replace(s, string.Empty);
        s = s.ToLower();
        var j = s.Length - 1;
        for(int i = 0 ; i < s.Length / 2; i++,j--)
        {
            if(s[i] != s[j])
                return false;
        }
        return true;
    }
}
