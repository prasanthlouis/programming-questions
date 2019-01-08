public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Count() == 0)
            return 0;
        int counter = 1;
        for(int i = 1 ; i < nums.Count(); i++)
        {
            if(nums[i] != nums[i-1])
            {
                nums[counter] = nums[i];
                counter++;
            }
        }
        return counter;
        
    }
}
