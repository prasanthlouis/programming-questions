using System.Text.RegularExpressions;
public class Solution {
    public bool IsNumber(string s) {
        s = s.Trim();
        var numberSeen = false;
        var numberSeenAfterE = false;
        var dotSeen = false;
        var eSeen = false;
        for(int i = 0 ; i < s.Length ; i++)
        {
            if(s[i] >= '0' && s[i] <= '9')
            {
                numberSeen = true;
                numberSeenAfterE = true;
            }
            else if(s[i] == '.')
            {
                if(dotSeen || eSeen)
                    return false;
                
                dotSeen = true;
            }
            else if(s[i] == 'e')
            {
                if(eSeen || !numberSeen)
                    return false;
                eSeen = true;
                numberSeenAfterE = false;
            }
            else if(s[i] == '+' || s[i] == '-')
            {
                if(i != 0 && s[i-1] != 'e')
                {
                    return false;
                }
            }
            else{
                return false;
            }
        }
        return numberSeen && numberSeenAfterE;
    }
}
