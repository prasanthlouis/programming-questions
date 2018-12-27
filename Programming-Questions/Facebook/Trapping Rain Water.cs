public class Solution {
    public int Trap(int[] height) {
        if(height.Count() == 0)
        {
            return 0;
        }
        var leftArray = new int[height.Count()];
        var rightArray = new int[height.Count()];
        leftArray[0] = height[0];
        for(int i = 1 ; i < height.Count() ; i++)
        {
            leftArray[i] = Math.Max(leftArray[i-1], height[i]);
        }
        rightArray[height.Count() - 1] = height[height.Count() - 1];
        for(int i = height.Count() - 2 ; i >= 0 ; i--)
        {
            rightArray[i] = Math.Max(rightArray[i+1], height[i]);
        }
        int count = 0;
        for(int i = 0 ; i < height.Count(); i++)
        {
            count += Math.Min(leftArray[i], rightArray[i]) - height[i];
        }
        
        return count;
    }
}
