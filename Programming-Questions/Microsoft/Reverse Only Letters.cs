public class Solution {
    public string ReverseOnlyLetters(string S) {
        var stringBuilder = new StringBuilder(101);
        for(int l =0 ; l < 101; l++)
        {
            stringBuilder.Append("\\");
        }
        for(int k = 0; k < S.Length; k++)
        {
            if(!Char.IsLetter(S[k]))
            {
                stringBuilder.Insert(k,S[k]);
            }
        }
        int i = 0;
        for(int j = S.Length - 1; j >=0 ; j--,i++)
        {
            if(Char.IsLetter(S[j]))
            {
                while(stringBuilder[i] != '\\')
                {
                i++;
                }
                stringBuilder[i] = S[j];      
            }
            else{
                i--;
            }
        }
        
        return stringBuilder.ToString().Replace("\\","");
        
    }
}
