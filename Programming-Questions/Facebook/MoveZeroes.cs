public class Solution {
    public void MoveZeroes(int[] nums) {
        var startPosition = 0;
        for(int i = 0 ; i < nums.Count() ; i++)
        {
            if(nums[i] != 0)
            {
                nums[startPosition++] = nums[i];
            }
        }
        for(int i = startPosition ; i < nums.Count(); i++)
        {
            nums[i] = 0;
        }
    }
}
