public class Solution {
    public int LengthOfLIS(int[] nums) {
        int size = 0;
        var answer = new int[nums.Count()];
        for(int k = 0 ; k < nums.Count(); k++)
        {
            int i = 0; 
            int j = size;
            while(i != j)
            {
                int mid = (i + j) / 2;
                if(answer[mid] < nums[k])
                {
                    i = mid + 1;
                }
                else{
                   j = mid;
                }
            }
            answer[i] = nums[k];
            if(i == size)
            {
                size++;
            }
            
        }
        return size;
    }
    
}
