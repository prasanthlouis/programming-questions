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
         var nextElement = s[i];
         if(stack.Count() > 0 )
         {
             if(dictionary.ContainsKey(nextElement)){
                 stack.Push(nextElement);
             }
             else{
                 if(dictionary.ContainsKey(stack.Peek()) && dictionary[stack.Peek()] == nextElement)
                 {
                     stack.Pop();
                 }
                 else{
                    break;
                 }
             }
         }
         else{
         stack.Push(nextElement);
         }
         
     }
        return (stack.Count() == 0);
    }
}
