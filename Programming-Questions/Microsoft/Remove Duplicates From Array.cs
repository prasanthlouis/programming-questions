public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Count() == 0)
            return 0;
        if(nums.Count() == 1)
            return nums[0];
        int index = 0;
        int currentNumber = int.MinValue;
        for(int i = 0; i < nums.Count(); i++)
        {
            
            if(currentNumber == nums[i]){
                currentNumber = nums[i];                
                nums[i] = int.MinValue;
            }
            else{
                currentNumber = nums[i];
                nums[index] = nums[i];
                if(index != i)
                nums[i] = int.MinValue;
                index++;           
            }
        }
        int count = 0;
        int j =0;
        while(j < nums.Count() && nums[j] != int.MinValue)
        {
            j++;
            count++;
        }
        return count;
    }
}

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Count() == 0)
            return 0;
        int i =0;
        for(int j = 1; j< nums.Count(); j++)
        {
            if(nums[i] != nums[j])
            {
                i++;
                nums[i] = nums[j];
            }
        }
        return i+1;
    }
}
