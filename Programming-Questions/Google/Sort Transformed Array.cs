public class Solution {
    public int[] SortTransformedArray(int[] nums, int a, int b, int c) {
        var answer = new int[nums.Count()];
        var index = a >= 0 ? nums.Count() - 1 : 0;
        int i = 0;
        int j = nums.Count() - 1;
        while(i <= j)
        {
            if(a>=0)
            {
                answer[index--] = Quad(nums[i], a, b, c) >= Quad(nums[j], a,b,c) ? Quad(nums[i++],a,b,c) : Quad(nums[j--], a,b,c);
            }
            else{
                answer[index++]= Quad(nums[i], a, b, c) >= Quad(nums[j], a,b,c) ? Quad(nums[j--],a,b,c) : Quad(nums[i++], a,b,c);
            }
        }
        return answer;
        
    }
    
    public int Quad(int x, int a, int b , int c)
    {
        return a * x * x + b * x + c;
    }
}
