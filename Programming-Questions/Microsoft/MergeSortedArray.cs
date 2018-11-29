public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        if(nums2.Count() == 0 || (nums2.Count() == 1 && nums2[0] == 0) && n == 0)
            return;
        var stack = new Stack<int>();
        int j = 0;
        int i =0;
        var copy = m;
        for(; i < copy; i++)
        {
            if(n == 0)
                break;
            if(nums1[i] <= nums2[j])
            {
                stack.Push(nums1[i]);
                m--;
            }
            else{
                while(j < nums2.Count() && nums1[i] > nums2[j])
                {
                    stack.Push(nums2[j]);
                    j++;
                    n--;
                }
                i--;
            }
        }
        while(n > 0)
        {
            stack.Push(nums2[j]);
            j++;
            n--;
        }
        while(m > 0)
        {
            Console.WriteLine(m);
            stack.Push(nums1[i]);
            i++;
            m--;
        }
        for(int b = nums1.Length - 1; b >= 0; b--)
        {
//            Console.WriteLine(stack.Count());
            nums1[b] = stack.Pop();
        }
    }
}
