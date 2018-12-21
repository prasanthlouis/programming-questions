public class Solution {
    public int MaxSubArray(int[] nums) {
        var currentMax = nums[0];
        var maxSoFar = nums[0];
        for(int i = 1; i < nums.Count(); i++)
        {
            currentMax = Math.Max(nums[i], currentMax + nums[i]);
            maxSoFar = Math.Max(currentMax, maxSoFar);
        }
        return maxSoFar;
        
    }
}
//DP Solution
public class Solution {
    public int MaxSubArray(int[] nums) {
        var maxSoFar = nums[0];
        var dp = new int[nums.Count()];
        dp[0] = nums[0];
        for(int i = 1; i < nums.Count(); i++)
        {
            dp[i] = nums[i] + (dp[i-1] > 0  ? dp[i-1]  : 0);
            maxSoFar = Math.Max(dp[i], maxSoFar);
        }
        return maxSoFar;
        
    }
}
