public class Solution {
    public bool IsOneEditDistance(string s, string t) {
        if(Math.Abs(s.Length - t.Length) > 1)
            return false;
        if(s.Length == t.Length)
            return IsOneEdit(s,t);
        if(s.Length > t.Length)
            return IsModify(s,t);
        else return IsModify(t,s);
    }
    
    public bool IsOneEdit(string s, string t)
    {
        int diff = 0;
        for(int i =0 ; i < s.Length ; i++)
        {
            if(s[i] != t[i])
                diff++;
        }
        return diff == 1;
    }
    
    public bool IsModify(string s, string t)
    {
    int j = 0;
     for(int i = 0; i < s.Length && j < t.Length; i++, j++)
     {
         if(s[i] != t[j])
         {
             return s.Substring(i + 1, s.Length - i - 1) == t.Substring(j, t.Length - j );
         }
     }
        return true;
    }
}
