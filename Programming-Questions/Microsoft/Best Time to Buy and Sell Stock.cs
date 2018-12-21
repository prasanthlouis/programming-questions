public class Solution {
    public int MaxProfit(int[] prices) {
        int maxCurrent = 0;
        int maxSoFar = 0;
        for(int i = 1; i < prices.Count() ; i++)
        {
            maxCurrent = Math.Max(0, maxCurrent += prices[i] - prices[i-1]);
            maxSoFar = Math.Max(maxCurrent, maxSoFar);         
        }
        return maxSoFar;
    }
}
