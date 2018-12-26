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
            if(dictionary.ContainsValue(s[i]))
            {
                if(stack.Count() > 0)
                {
                var topElement = stack.Pop();
                if(dictionary[topElement] != s[i])
                    return false;
                }else{
                    return false;
                }
            }
            else{
                    stack.Push(s[i]);
                }
        }
        return stack.Count() == 0;
    }
}
