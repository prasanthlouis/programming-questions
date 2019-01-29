//Time complexity = O(n + k)
//SpaceComplexity should be O(1). I could clean this up

public class Solution {
    public int[] GetModifiedArray(int length, int[,] updates) {
        var answer = new int[length];
        for(int i = 0 ; i < updates.GetLength(0); i++)
        {
            var start = updates[i,0];
            var end = updates[i,1];
            var addition = updates[i,2];
            answer[start] += addition;
            if(end+1 < answer.Length)
            answer[end+1] -= addition;
        }
        int sum = 0;
        for(int i = 0 ; i < answer.Count() ; i++)
        {
            sum += answer[i];
            answer[i] = sum;
        }
        return answer;
        
    }
}
