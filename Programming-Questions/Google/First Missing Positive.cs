public class Solution {
    public int FirstMissingPositive(int[] nums) {
        if(nums.Count() == 0)
            return 1;
        if(nums.Count() == 1)
            if(nums[0] == 1)
            {
                return 2;
            }else{
                return 1;
            }
        int max = -1;
        for(int i = 0 ; i < nums.Count() ; i++)
        {
            while(nums[i] > 0 && nums[i] <= nums.Count() - 1 && nums[i] != nums[nums[i] - 1])
            {
                var temp = nums[i];
                nums[i] = nums[nums[i] - 1];
                nums[temp - 1] = temp;
            }
                
        }
        for(int i = 0 ; i < nums.Count(); i++)
        {
            if(nums[i] != i + 1)
                return i + 1;
        }
        return nums.Count() + 1;
    }
}


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
