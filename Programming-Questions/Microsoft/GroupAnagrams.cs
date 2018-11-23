public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        IList<IList<string>> answerList = new List<IList<string>>();
        var copy = new List<string>();
            var visited = new List<bool>();
        
        for(var i = 0 ; i < strs.Length ; i++)
        {
            copy.Add(strs[i]);
            visited.Add(false);
            strs[i] = String.Concat(strs[i].OrderBy(c => c));
        }
        for(int i = 0; i < strs.Length; i++)
        {
            var temp = new List<string>();
            var elementToCompare = strs[i];
            for(int j = 0 ; j < strs.Length; j++)
            {
                if(elementToCompare == strs[j] && visited[j] == false)
                {
                    temp.Add(copy[j]);
                    visited[j] = true;
                }
            }
            if(temp.Count() > 0)
            answerList.Add(temp);
        }
        return answerList;
    }
}



//OR

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        IList<IList<string>> answerList = new List<IList<string>>();
        var dictionary = new Dictionary<string,List<string>>();
        var stringBuilder = new StringBuilder();
        for(int i = 0 ; i < strs.Length ; i++)
        {       
            var count = new int[26];
            foreach(var character in strs[i])
            {
                count[character - 'a']++;
            }
            for(int k = 0; k < 26 ; k++)
            {
                stringBuilder.Append(count[k]);
                stringBuilder.Append('#');
            }
            if(!dictionary.ContainsKey(stringBuilder.ToString()))
               {
                   dictionary.Add(stringBuilder.ToString(), new List<string>(){strs[i]});
               }
               else{
                   dictionary[stringBuilder.ToString()].Add(strs[i]);
               }
            Console.WriteLine(stringBuilder.ToString());
            stringBuilder.Clear();
        }
               var values = dictionary.Values;
        var answer = new List<IList<string>>();
        foreach(var value in values)
        {
            answer.Add(value);
        }
        return answer;
    }
}
