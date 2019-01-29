//Time Complexity = O(n)
//Space Complexity = O(n)

//Dynamic Programming

public class Solution {
    public int Trap(int[] height) {
        if(height.Count() == 0)
            return 0;
        var left = new int[height.Count()];
        left[0] = height[0];
        for(int i = 1; i < height.Count(); i++)
        {
            left[i] = Math.Max(left[i-1], height[i]);
        }
        var right = new int[height.Count()];
        right[height.Count() - 1] = height[height.Count() - 1];
        for(int i = height.Count() - 2 ; i >= 0 ; i--)
        {
            right[i] = Math.Max(right[i+1], height[i]);
        }
        var counter = 0;
        for(int i = 0; i < height.Count(); i++)
        {
            counter += Math.Min(left[i], right[i]) - height[i];
        }
        return counter;
    }
}
