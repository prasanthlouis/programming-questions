public class Solution {
    public string ShortestPalindrome(string s) {
        if(string.IsNullOrWhiteSpace(s))
            return string.Empty;
        
        if(s.Length == 1)
            return s;
        
        return Recurse(s);
    }
    
    public string Recurse(string s)
    {
        int j = 0;
        int i = s.Length - 1;
        for(; i >= 0; i--)
        {
                if(s[i] == s[j])
                    j++;
        }
        if(s.Length == j )
            return s;
        
        var suffix = s.Substring(j, s.Length - j );
        int k = suffix.Length - 1;
        Console.WriteLine($"{s} {j} {s.Length-j} {suffix}");
        var recurse = Recurse(s.Substring(0, j));
        return new StringBuilder(new string(suffix.Reverse().ToArray()) + recurse + suffix).ToString();
    }
}
