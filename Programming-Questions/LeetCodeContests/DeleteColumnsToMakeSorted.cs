public class Solution {
    public int MinDeletionSize(string[] A) {
        int count = 0;
        for(int j = 0; j < A[0].Length ; j++)
        {
            int i = 0;
            while(i+1 < A.Count() && A[i][j] <= A[i+1][j])
                i++;
            if(i != A.Count() - 1)
                count++;
        }
        return count;
    }
}
