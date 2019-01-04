public class Solution {
    public bool IsValid(string s) {
        if(string.IsNullOrWhiteSpace(s))
        {
            return true;
        }
        var stack = new Stack<char>();
        var dictionary = new Dictionary<char,char>();
        dictionary.Add('(',')');
        dictionary.Add('{','}');
        dictionary.Add('[',']');
    
        for(int i = 0 ; i < s.Length ; i++)
        {
            if(dictionary.ContainsKey(s[i]))
            {
                stack.Push(s[i]);
            }
            else{
                if(stack.Count() > 0)
                {
                    var element = stack.Pop();
                    if(dictionary[element] != s[i])
                    {
                        return false;
                    }
                }
                else{
                    return false;
                }
            }
        }
        return stack.Count() == 0;

    }
}
