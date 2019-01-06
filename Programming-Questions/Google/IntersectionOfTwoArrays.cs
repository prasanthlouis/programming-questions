public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        var answerList = new List<int>();
        var nums1List = nums1.ToList();
        var nums2List = nums2.ToList();
        for(int i = 0 ; i < nums1.Count() ; i++)
        {
            if(nums2.Contains(nums1[i]) && !answerList.Contains(nums1[i]))
            {
                answerList.Add(nums1[i]);
            }
        }
        return answerList.ToArray();
    }
}
