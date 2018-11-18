public class Solution {
    public int MyAtoi(string str) {
        var sign = 1;
        if(string.IsNullOrWhiteSpace(str))
            return 0;
        str = str.Trim();
        int i = 0;
        if(str[0] == '-' || str[0] == '+')
        {
            if(str[0] == '-')
            sign = -1;
        i = 1;
        }
        long result = 0;
        while(i < str.Length)
        {
            if(char.IsNumber(str[i]))
            {
            result = (result * 10) + (str[i] - '0');
            if(result * sign > int.MaxValue)
            {
                return int.MaxValue;
                
            }
            if(result * sign < int.MinValue)
            {
                return int.MinValue;
                
            }
            }
            else{
            break;}
            i++;
        }
        return (int)result * sign;
    }
}
