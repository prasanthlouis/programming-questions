//Time Complexity = O(n)
//Uses sliding window

public class Solution {
    public int KEmptySlots(int[] flowers, int k) {
        var days = new int[flowers.Count()];
        for(int i = 0; i < flowers.Count(); i++)
        {
            days[flowers[i] - 1] = i + 1;     
        }

        
        var result = int.MaxValue;
        var left = 0 ;
        var right = k + 1;
        for(int i = 1 ; right < days.Count(); i++)
        {
            if(days[i] > days[left] && days[i] > days[right])
                continue;
            
            if(i == right)
                result = Math.Min(result, Math.Max(days[left],days[right]));
            
            left = i ;
            right = left + k + 1;
        }
        return result == int.MaxValue ? -1 : result;
    }
}
