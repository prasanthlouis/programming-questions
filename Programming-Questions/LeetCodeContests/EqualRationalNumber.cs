public class Solution {
    public bool IsRationalEqual(string S, string T) {
        return F(S) == F(T);
    }
    public double F(string S)
    {
        if(S.Contains("("))
        {
            var index = S.IndexOf("(");
            var baseno = S.Substring(0, index);
            var repeating = S.Substring(index + 1, S.Length - index - 2);
            Console.WriteLine($"{baseno} {repeating}");
            for(int i =0 ; i < 20; i++)
            {
                baseno += repeating;
            }
            return Double.Parse(baseno);
        }
        return Double.Parse(S);
    }
}
