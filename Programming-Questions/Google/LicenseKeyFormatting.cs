public class Solution {
    public string LicenseKeyFormatting(string S, int K) {
        var sb = new StringBuilder();
        for(int i = S.Length - 1 ; i >= 0 ; i--)
        {
            if(S[i] == '-')
                continue;
            sb.Append(sb.Length % (K+1) == K? "-": "").Append(S[i]);
        }
        char[] arr = sb.ToString().ToUpper().ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}
