public class Solution {
    public int FirstUniqChar(string s) {
        if(string.IsNullOrWhiteSpace(s))
            return -1;
        var list = new List<int>(26);
        for(int i = 0 ; i < 26 ;i++)
        {
            list.Add(0);
        }
        for(int i = 0 ; i < s.Length; i++)
        {
            list[(char)s[i] - 'a']++;
        }
        for(int i = 0 ; i < s.Length; i++)
        {
            if(list[s[i] - 'a'] < 2)
                return i;
        }
            return -1;
    }
}
