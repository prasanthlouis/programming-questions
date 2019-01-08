public class Solution {
    public void MoveZeroes(int[] nums) {
        int pointer = 0;
        for(int i = 0; i < nums.Count() ; i++)
        {
            if(nums[i] != 0)
            {
                nums[pointer] = nums[i];
                pointer++;
            }
        }
        for(int i = pointer; i < nums.Count(); i++)
        {
            nums[i] = 0;
        }
    }
}
