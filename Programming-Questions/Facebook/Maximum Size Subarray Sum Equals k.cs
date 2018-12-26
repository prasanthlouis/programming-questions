public class Solution {
    public int MaxSubArrayLen(int[] nums, int k) {
        var dictionary = new Dictionary<int, int>();
        for(int i = 1 ; i < nums.Count() ; i++)
        {
            nums[i] += nums[i-1];
        }
        int max = 0;
        dictionary.Add(0, -1);
        for(int i = 0 ; i < nums.Count() ; i++)
        {
            if(dictionary.ContainsKey(nums[i] - k))
            {
                max = Math.Max(max, i - dictionary[nums[i] - k]);
            }
            if(!dictionary.ContainsKey(nums[i]))
            {
                dictionary.Add(nums[i], i);
            }
        }
        return max;
    }
}
