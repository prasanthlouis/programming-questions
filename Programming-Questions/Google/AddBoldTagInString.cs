public class Solution {
    public string AddBoldTag(string s, string[] dict) {
        
        var sb = new StringBuilder(s);
        var mark = new int[s.Length + 1];
        foreach(var thing in dict)
        {
            int index = -1;
            while((index = sb.ToString().IndexOf(thing, index + 1)) >= 0)
            {
                Console.WriteLine(index);
                mark[index]++;
                mark[index + thing.Length]--;
            }
        }
        int sum = 0;
        sb.Clear();
        for(int i = 0 ; i < s.Length + 1; i++)
        {
            int cur = sum + mark[i];
            if(sum == 0 && cur > 0)
            {
                sb.Append("<b>");
            }
            if(sum > 0 && cur == 0)
            {
                sb.Append("</b>");
            }
            if(i < s.Length)
            sb.Append(s[i]);
            sum = cur;
        }
        return sb.ToString();
    }
}
