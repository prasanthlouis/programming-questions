public class Solution {
    public void ReverseWords(char[] str) {
        int j = str.Count() - 1;
        char temp;
        int i = 0;
        for( ; i < str.Count() / 2  ; i++, j--)
        {
            temp = str[i];
            str[i] = str[j];
            str[j] = temp;
        }
        int k = 0;
        i = 0;
        int pointer = 0;
        while(k < str.Count())
        {
            while(k < str.Count() && str[k] != ' ')
            {
                k++;
            }
            pointer = k;
            var limit = k - i;
            k--;
            for(int l = 0; l < limit/2; i++, k--, l++)
            {
                temp = str[i];
                str[i] = str[k];
                str[k] = temp;
            }

            pointer++;
            i = k = pointer;
        }
    }
}
