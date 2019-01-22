public class Solution {
    public int LengthOfLongestSubstringKDistinct(string s, int k) {
        var dictionary = new Dictionary<char,int>();
        
        int counter = 0;
        int start = 0;
        int end = 0;
        int max = 0;
        for(int i = 0 ; i < s.Length ; i++)
        {
            if(!dictionary.ContainsKey(s[end]))
            {
                dictionary.Add(s[end], 1);
                counter++;
            }
            else{
                dictionary[s[end]]++;
            }
            var length = end - start + 1;
            if(counter <= k && length > max)
            {
                Console.WriteLine($"{length} {max} {counter}");
                max = length;
            }
            
            while(counter > k)
            {
                dictionary[s[start]]--;
                if(dictionary[s[start]] == 0)
                {
                    dictionary.Remove(s[start]);
                    counter--;
                }
                start++;
            }
            end++;

        }
        if(end - start > max && counter <= k)
            max = end - start + 1;
        return max;
    }
}
