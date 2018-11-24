public class Solution {
    public int Trap(int[] height) {
        if(height.Count() == 0)
        {
            return 0;
        }
        var leftMax = new int[height.Count()];
        leftMax[0] = height[0];
        for(var i = 1 ; i < height.Count(); i++)
        {
            leftMax[i] = Math.Max(height[i], leftMax[i-1]);
        }
        var rightMax = new int[height.Count()];
        rightMax[height.Count() - 1] = height[height.Count() - 1];
        for(var i = height.Count() - 2; i >=0 ; i--)
        {
            rightMax[i] = Math.Max(height[i], rightMax[i+1]);
        }
        
        var answer = 0;
        for(int i = 0; i < height.Count(); i++)
        {
            answer += Math.Min(leftMax[i], rightMax[i]) - height[i];
        }
        return answer;
    }
}
