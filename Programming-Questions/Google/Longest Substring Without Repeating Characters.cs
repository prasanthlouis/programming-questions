public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(string.IsNullOrWhiteSpace(s) && s == s.Trim())
            return 0;
        if(string.IsNullOrWhiteSpace(s))
           return 1;
        int i = 0;
        int max = -1;
        var dictionary = new Dictionary<char, int>();
        for(int j = 0 ; j < s.Length && j < s.Length;j++)
        {
            if(dictionary.ContainsKey(s[j]))
            {
                i = Math.Max(dictionary[s[j]], i);
            }
            max = Math.Max(max, j - i + 1);
            if(dictionary.ContainsKey(s[j]))
                dictionary[s[j]] = j + 1;
            else
            dictionary.Add(s[j], j + 1);
        }
        return max;
        
    }
}

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(string.IsNullOrWhiteSpace(s) && s == s.Trim())
            return 0;
        if(string.IsNullOrWhiteSpace(s))
           return 1;
        int j = 0;
        int max = -1;
        var dictionary = new HashSet<char>();
        for(int z = 0 ; z < s.Length && j < s.Length ;)
        {
            if(!dictionary.Contains(s[j]))
            {
                dictionary.Add(s[j++]);
                var length = j - z;
                if(length > max)
                    max = length;
            }
            else{
                dictionary.Remove(s[z++]);
            }
        }
        return max;
        
    }
}

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(string.IsNullOrWhiteSpace(s) && s == s.Trim())
            return 0;
        if(string.IsNullOrWhiteSpace(s))
           return 1;
        int j = 1;
        int max = -1;
        var dictionary = new Dictionary<char,int>();
        for(int z = 0 ; z < s.Length ;)
        {
            dictionary.Add(s[z], 1);
            
            while(j < s.Length && !dictionary.ContainsKey(s[j]))
            {
                dictionary.Add(s[j], 1);
                j++;
            }
                var length = j - z;
                if(length > max)
                    max = length;
                z++;
                j = z + 1;
                dictionary = new Dictionary<char,int>();
        }
        return max;
        
    }
}
