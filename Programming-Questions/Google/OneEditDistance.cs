public class Solution {
    public bool IsOneEditDistance(string s, string t) {
        if((string.IsNullOrWhiteSpace(s) && t.Length == 1) || (s.Length == 1 && string.IsNullOrWhiteSpace(t))){
            return true;
        }
        var length = Math.Max(s.Length, t.Length);
        
        var firstCase = false;
        var secondCase = false;
        var thirdCase = false;
        var sStringBuilder = new StringBuilder(s);
        var tStringBuilder = new StringBuilder(t);
        int count = 0;
        for(int i = 0 ; i < length; i++)
        {
            if(i < s.Length && i < t.Length)
            {
                if(s[i] != t[i])
                {
                    firstCase = Insert(s,t,i,length);
                    if(!firstCase)
                        secondCase = Replace(s,t,i,length);
                    else break;
                    if(!secondCase)
                        thirdCase = Delete(s,t,i,length);
                    else break;
                    break;
                }
                else{
                    if(sStringBuilder.ToString().Length >= 1 && tStringBuilder.ToString().Length >= 1)
                    {
                    sStringBuilder.Remove(count,1);
                    tStringBuilder.Remove(count,1);
                    }
                }
            }
        }
                if((string.IsNullOrWhiteSpace(sStringBuilder.ToString()) && tStringBuilder.ToString().Length == 1) || (sStringBuilder.ToString().Length == 1 && string.IsNullOrWhiteSpace(tStringBuilder.ToString()))){
            return true;
        }
        
        Console.WriteLine($"{firstCase} {secondCase} {thirdCase}");
        return firstCase || secondCase || thirdCase;
    }
   
     public bool Delete(string s, string t, int i , int length)
    {
        var sb = new StringBuilder(s);
        sb.Remove(i, 1);
         Console.WriteLine($"Remove {sb.ToString()}");
         Console.WriteLine($"{t} {sb.ToString()}");
         return Check(sb, s, t, i, --length);
    }
    
    public bool Replace(string s, string t, int i , int length)
    {
        var sb = new StringBuilder(s);
        sb[i] = t[i];
         return Check(sb, s, t, i, length);
    }
    
    public bool Insert(string s, string t, int i, int length)
    {
        var sb = new StringBuilder(s);
        sb.Insert(i,t[i]);
        return Check(sb, s, t, i, length);
    }
    public bool Check(StringBuilder sb, string s, string t, int i, int length){
        if(sb.ToString().Length != t.Length)
            return false;
        s = sb.ToString();
        for(; i < length; i++)
        {
            if(i >= s.Length || i >= t.Length || s[i] != t[i])
                return false;
        }
        return true;
    }
}
