
public class TrieNode{
       Trie root;
    public char Val{get;set;}
    public bool IsWord{get;set;}
    public TrieNode[] Children = new TrieNode[26]; 
    public TrieNode(){}
    public TrieNode(char c)
    {
        var trie = new TrieNode();
        trie.Val = c;
    }
}
public class Trie {

    /** Initialize your data structure here. */
TrieNode root;
    public Trie() {
        root = new TrieNode();
        root.Val = ' ';
    }
    
    
    
    /** Inserts a word into the trie. */
    public void Insert(string word) {
        var temp = root;
        int i = 0;
        for(; i < word.Length ; i++)
        {
            if(temp.Children[word[i] - 'a'] == null)
            {
                temp.Children[word[i] - 'a'] = new TrieNode(word[i]);
            }
        temp = temp.Children[word[i] - 'a'];
            
        }
        
        temp.IsWord = true;      
    }
    
    /** Returns if the word is in the trie. */
    public bool Search(string word) {
        var temp = root;
        int i =0;
        for( ; i < word.Length ; i++)
        {
            if(temp.Children[word[i] - 'a'] == null)
                return false;
            temp = temp.Children[word[i] - 'a'];
        }
        if(temp.IsWord)
            return true;
        return false;
    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix) {
        var temp = root;
        int i =0;
        for( ; i < prefix.Length ; i++)
        {
            if(temp.Children[prefix[i] - 'a'] == null)
                return false; 
            
            temp = temp.Children[prefix[i] - 'a'];
        }
            return true;
    
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
