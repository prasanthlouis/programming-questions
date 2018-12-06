public class Solution {
    public bool IsMatch(string s, string p) {
        if(string.IsNullOrWhiteSpace(p))
            return string.IsNullOrWhiteSpace(s);
        
        var firstMatch = (!string.IsNullOrWhiteSpace(s)) && (s[0] == p[0] || p[0] == '.');
        
        if(p.Length >= 2 && p[1] == '*')
        {
            return IsMatch(s, p.Substring(2))||
                firstMatch && IsMatch(s.Substring(1), p);
        }
        else{
            return firstMatch && IsMatch(s.Substring(1), p.Substring(1));
        }
    }
}
