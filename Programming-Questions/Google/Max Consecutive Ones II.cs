public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        if(nums.Count() == 1)
        {
            return 1;
        }
        int max = -1;
        int counter = 0;
        int index = -1;
        for(int i = 0 ; i < nums.Count(); i++)
        {
            if(nums[i] == 1)
            {
                counter++;
            }
            else{
                counter++;
                i++;
                index = i;
                while(i < nums.Count() && nums[i] == 1)
                {
                    counter++;
                    i++;
                }
                if(counter > max)
                {
                    max = counter;
                }
                counter = i - index;
                i--;
            }
        }
        if(counter > max)
            max = counter;
        return max;
    }
}
