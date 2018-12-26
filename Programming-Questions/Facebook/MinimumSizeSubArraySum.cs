public class Solution {
    public int MinSubArrayLen(int s, int[] nums) {
        if(nums.Count() == 0)
            return 0;
        int i = 0;
        int j = 0;
        int sum = 0;
        int localAnswer = 0;
        int answer = int.MaxValue;
        for(i = 0 ; i < nums.Count() ; i++)
        {
            sum += nums[i];
            localAnswer++;
            while(sum >= s)
            {
                answer = Math.Min(answer, localAnswer);
                sum -= nums[j];
                j++;
                localAnswer--;
            }
        }
        return answer == int.MaxValue ? 0 : answer;
    }
}
