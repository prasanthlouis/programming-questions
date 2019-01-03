using System.Text.RegularExpressions;
public class Solution {
    public bool IsNumber(string s) {
        bool isNumberSeen = false;
        bool isESeen = false;
        bool isSuccessiveSign = false;
        int dotCounter = 0;
        int eCounter = 0;
        s = s.Trim();
        for(int i = 0 ; i < s.Length ; i++)
        {
            if(s[i] >= '0' && s[i] <= '9')
            {
                isNumberSeen = true;
            }
            else if(s[i] == '.')
            {
                dotCounter++;
                if(dotCounter > 1)
                    return false;
                if(isESeen)
                    return false;
            }
            else if(s[i] == '-' || s[i] == '+')
            {
                if(isSuccessiveSign)
                    return false;
                if(!isESeen && isNumberSeen)
                    return false;
                if(dotCounter >= 1 && !isESeen)
                    return false;
                isSuccessiveSign = true;
                isNumberSeen = false;
                continue;
            }
            else if(char.TryParse(s[i].ToString(), out var character))
            {
                if(character != 'e')
                    return false;
                else{
                    eCounter++;
                    if(!isNumberSeen)
                        return false;
                    if(eCounter > 1)
                        return false;
                    isESeen = true;
                    isNumberSeen = false;
                }
            }
            isSuccessiveSign = false;
            
        }
        return isNumberSeen;
    }
}
