public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        var dictionary = new Dictionary<int,int>();
        var result = new List<int>();
        for(int i = 0 ; i < nums1.Count(); i++)
        {
            if(dictionary.ContainsKey(nums1[i]))
                dictionary[nums1[i]] = ++dictionary[nums1[i]];
            else{
                dictionary.Add(nums1[i], 1);
            }
        }
        for(int i = 0 ; i < nums2.Count() ; i++)
        {
            if(dictionary.ContainsKey(nums2[i]) && dictionary[nums2[i]] >= 1){
                result.Add(nums2[i]);
                dictionary[nums2[i]] = --dictionary[nums2[i]];
            }
        }
        var x = new int[result.Count()];
        for(int i = 0 ; i < result.Count() ; i++)
        {
            x[i] = result[i];
        }
        return x;
    }
}
