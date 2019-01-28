//Time complexity = O(N * (M + N))
//Space complexity = O(M+N)

//Ad hoc
public class Solution {
    public int RepeatedStringMatch(string A, string B) {
        int count = 1;
        var ACopy = A;
        var maxLength = Math.Max(A.Length, B.Length);
        var stringBuilder = new StringBuilder();
        stringBuilder.Append(A);
        while(stringBuilder.Length < B.Length)
        {
            stringBuilder.Append(ACopy);
            count++;
        }
            if(stringBuilder.ToString().Contains(B))
                return count;
            stringBuilder.Append(ACopy);
            if(stringBuilder.ToString().Contains(B))
                return ++count;
            return -1;
    }
}
