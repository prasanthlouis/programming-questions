public class Solution {
    public string MinWindow(string s, string t) {
        var dictionary = new Dictionary<char, int>();
        var minimumLength = int.MaxValue;
        var length = 0;
        var head = 0;
        for(int i = 0; i < 128; i++)
        {
            dictionary.Add((char)('A' + i), 0);
        }
        for(int i = 0 ; i < t.Length ; i++)
        {
            dictionary[t[i]]++;
        }
        var counter = t.Length;
        var start = 0;
        var end = 0;
        while(end < s.Length)
        {
            if(dictionary[s[end]] > 0)
                counter--;
            dictionary[s[end]]--;
            end++;
            while(counter == 0)
            {
                if(end-start < minimumLength)
                {
                    head = start;
                    length = end-start;
                    minimumLength = length;
                }
                
                dictionary[s[start]]++;
                if(dictionary[s[start]] > 0)
                    counter++;
                start++;
            }
            
        }
        if(length != int.MaxValue)
        return s.Substring(head,length);
        else
            return string.Empty;
        
        
    }
}
