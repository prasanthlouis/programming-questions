public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var N1 = nums1.Count();
        var N2 = nums2.Count();
        if(N2 > N1)
        {
            return FindMedianSortedArrays(nums2, nums1);
        }
        
        int low = 0;
        int high = N2 * 2;
        while(low <= high)
        {
            var med2 = (low + high) / 2;
            var med1 = N1 + N2 - med2;
            
            double L1 = med1 == 0 ? int.MinValue : nums1[(med1-1) / 2];
            double L2 = med2 == 0 ? int.MinValue : nums2[(med2-1) / 2];
            double R1 = med1 == (N1 * 2) ? int.MaxValue : nums1[(med1) / 2];
            double R2 = med2 == (N2 * 2) ? int.MaxValue : nums2[(med2) / 2];
            
            if(L1 > R2)
            {
                low = med2 + 1;
            }
            else if (L2 > R1){
                high = med2 - 1;
            }
            else{
                return (Math.Max(L1,L2) + Math.Min(R1,R2)) / 2;
            }
        }
        return -1;
    }
}
