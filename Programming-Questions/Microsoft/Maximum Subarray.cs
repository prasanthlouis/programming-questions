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
