public class Solution {
    public int FindMin(int[] nums) {
        if(nums.Count() == 1)
            return nums[0];
        var min = nums[0];
        int i = 0;
        for(; i < nums.Count(); i++)
        {
            if(i + 1 < nums.Count() && nums[i] >= nums[i+1] && nums[i+1] < min)
            {
                min = nums[i+1];
            }
        }
        if(nums[i-1] < min)
            {
            min = nums[i-1];
        };
        return min;
    }
}
