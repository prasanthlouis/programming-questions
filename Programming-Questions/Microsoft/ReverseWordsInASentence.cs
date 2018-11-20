public class Solution {
    public string ReverseWords(string s) {
        var list = new List<string>();
        var builder=  new StringBuilder();
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == ' ')
            {
                builder.Insert(0, ' ');
                list.Add(builder.ToString());
                builder.Clear();
                continue;
            }
            builder.Append(s[i]);
        }
        list.Add(builder.ToString()); 
        builder.Clear();
        for(int i = list.Count() - 1; i >= 0 ; i--)
        {
            builder.Append(list[i]);
        }
        var str = builder.ToString();
        while(str.Contains("  ")) 
        {
            str = str.Replace("  ", " ");
        }
        return str.Trim();
    }
}
