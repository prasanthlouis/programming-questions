public class Solution {
    public string ReverseString(string s) {
        var x = new StringBuilder(s);
        string t = string.Empty;
        int j = 0;
        for(int i = s.Length - 1; i >= s.Length/2; i--, j++)
        {
            var temp = x[i];
            x[i] = x[j];
            x[j] = temp;
        }
        return x.ToString();
        
    }
}
