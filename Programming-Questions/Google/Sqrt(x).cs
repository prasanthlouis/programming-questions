public class Solution {
    public int MySqrt(int x) {
        if(x == 0)
            return 0;
        double i = 1;
        double j = int.MaxValue;
        return Convert.ToInt32(Recurse(x, i, j));
    }
    
    public double Recurse(double x, double i, double j)
    {
        double low = i;
        double high = j;
        double mid = 0; 
        while(low <= high)
        {    
            mid = (low + high) / 2;
            if(mid * mid == x)
            {
                return mid;
            }
            else if(mid * mid > x)
            {
                if((mid-1) * (mid-1) < x)
                {
                    return mid - 1;
                }
                high = mid - 1;
            }
            else if(mid * mid < x)
            {
                if((mid+1) * (mid + 1) > x)
                {
                    return mid;
                }
                low = mid + 1;
            }
        }
        return mid;
    }
}
