public class Solution {
    public int SingleNumber(int[] nums) {
        int answer = 0;
        for(int i = 0 ; i < nums.Count() ; i++)
        {
            answer ^= nums[i];
        }
        return answer;
    }
}
