public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        if(nums.Count() == 1)
        {
            if(nums[0] == 1)
                return 1;
            return 0;
        }
        var max = 0;
        var counter = 0;
        for(int i =0 ; i < nums.Count(); i++)
        {
            if(nums[i] == 1)
            {
                counter++;
            }
            else{
                if(counter > max)
                    max = counter;
                counter = 0;
            }
        }
        if(counter > max)
            max = counter;
        return max;
    }
}
