public class Solution {
    public bool IsMatch(string str, string pat) {
        int s = 0;
        int p = 0;
        int startIndex = -1;
        int match = 0;
        while(s < str.Length)
        {
            if(p < pat.Length && pat[p] == '?' || p< pat.Length &&  pat[p] == str[s] )
            {
                p++;
                s++;
            }
            
            else if(p < pat.Length && pat[p] == '*')
            {
                startIndex = p;
                match = s;
                p++;
            }
            else if ( startIndex != -1)
            {
                p = startIndex + 1;
                match++;
                s = match;                
            }
            else{
                return false;
            }
        }
        
        while(p < pat.Length && pat[p] == '*')
        {
            p++;
        }
        return p == pat.Length;
    }
    
}
