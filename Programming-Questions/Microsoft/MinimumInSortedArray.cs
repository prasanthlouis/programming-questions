public class Solution {
    public int FindMin(int[] nums) {
        int length = nums.Count();
        if(length == 1)
            return nums[0];
        int i = 0;
        for(; i < length; i++)
        {
            if(i+1 < nums.Length && nums[i] > nums[i+1])
                return nums[i+1];
        }
        if(nums[i-1] < nums[i-2])
            return nums[i-1];
        return nums[0];
    }
}
