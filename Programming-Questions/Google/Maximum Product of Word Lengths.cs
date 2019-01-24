public class Solution {
    public int MaxProduct(string[] words) {
        var max = 0;
        var values = new int[words.Count()];
        for(int i = 0 ; i < words.Count(); i++)
        {
            values[i] = 0;
            var currentWord = words[i];
            for(int j = 0 ; j < currentWord.Length; j++)
            {
                values[i] |= 1 << currentWord[j] - 'a';
            }
        }
        for(int i = 0 ; i < words.Count(); i++)
        {
            for(int j = i + 1; j < words.Count(); j++)
            {
                if((values[i] & values[j]) == 0 && words[i].Length * words[j].Length > max)
                {
                    max = words[i].Length * words[j].Length;
                }
            }
        }
        return max;
    }
}
