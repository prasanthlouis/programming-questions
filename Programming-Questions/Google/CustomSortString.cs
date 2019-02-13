public class Solution {
    public string CustomSortString(string S, string T) {
        var count = new int[26];
        foreach(var x in T)
        {
            count[x - 'a']++;
        }
        
        var sb = new StringBuilder();
        foreach(var x in S)
        {
            for(int i = 0 ; i < count[x - 'a']; i++)
            {
                sb.Append(x);
            }
            count[x - 'a'] = 0;
        }
        
        for(char c = 'a' ; c <= 'z' ; c++)
        {
            for(int i = 0; i < count[c - 'a']; i++)
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
}
