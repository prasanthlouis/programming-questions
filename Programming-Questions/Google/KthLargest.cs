public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var list = new List<int>(nums);
        list.Sort();
        return list[list.Count() - k];
    }
}

public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        int low = 0;
        int high = nums.Count() - 1;
        k = nums.Count() - k;
        while(low < high)
        {
            var j = Partition(nums, low, high);
            if(j < k)
            {
                low = j + 1;
            }
            else if(j > k)
            {
                high = j - 1;
            }
            else{
                break;
            }
        }
        return nums[k];
    }
    
    public int Partition(int[] nums, int low , int high)
    {
        int i = low;
        int j = high + 1;
        while(true)
        {
            while(i < high && Less(nums[++i], nums[low]));
            while(j > low && Less(nums[low], nums[--j]));
            if(i >= j)
                break;
            Swap(nums,i,j);
        }
        Swap(nums,low,j);
        return j;
    }
    
    public bool Less(int i, int j)
    {
        return i < j;
    }
    
    public void Swap(int[] nums, int i , int j)
    {
        var temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}
