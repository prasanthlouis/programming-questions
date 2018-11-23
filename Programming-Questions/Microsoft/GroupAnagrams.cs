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
