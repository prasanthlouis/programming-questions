public class Solution {
    public int FirstMissingPositive(int[] nums) {
        if(nums.Count() == 0)
            return 1;

        int max = -1;
        for(int i = 0 ; i < nums.Count() ; i++)
        {
            if(nums[i] > max)
                max = nums[i];
        }
        var sorted = new int[max + 1];
        for(int i = 0 ; i < nums.Count() ; i++)
        {
            if(nums[i] >= 0)
            {
                var index = nums[i];
                sorted[index] = nums[i];
            }
        }
        for(int i = 1 ; i < sorted.Count(); i++)
        {
            if(sorted[i] != i)
                return i;
        }
        return sorted.Count();
    }
}
