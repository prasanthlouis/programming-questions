public class MagicDictionary {
    List<string> list;
    /** Initialize your data structure here. */
    public MagicDictionary() {
        list = new List<string>();
    }
    
    /** Build a dictionary through a list of words */
    public void BuildDict(string[] dict) {
        foreach(var d in dict.ToList())
        {
            list.Add(d);
        }
    }
    
    /** Returns if there is any word in the trie that equals to the given word after modifying exactly one character */
    public bool Search(string word) {
        foreach(var listedWord in list)
        {
            if(listedWord.Length != word.Length)
                continue;
            
            var foundWord = Compare(listedWord, word);
            if(foundWord)
                return true;
        }
        return false;
    }
    
    public bool Compare(string word, string list)
    {
        int i = 0;
        while(i < word.Length && word[i] == list[i])
            i++;
        
        if(i == word.Length)
            return false;
        
        i++;
        while(i < word.Length && word[i] == list[i])
            i++;
        
        return i == word.Length ? true : false;
        
    }
}

/**
 * Your MagicDictionary object will be instantiated and called as such:
 * MagicDictionary obj = new MagicDictionary();
 * obj.BuildDict(dict);
 * bool param_2 = obj.Search(word);
 */
