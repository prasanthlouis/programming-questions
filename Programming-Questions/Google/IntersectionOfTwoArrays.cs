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


public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        var dictionary = new Dictionary<int,int>();
        var answerDictionary = new Dictionary<int, int>();
        var answerList = new List<int>();
        for(int i = 0 ; i < nums1.Count() ; i++)
        {
            if(dictionary.ContainsKey(nums1[i]))
            {
                dictionary[nums1[i]]++;
            }
            else{
            dictionary.Add(nums1[i],1);
                }
        }      
        for(int i = 0 ; i < nums2.Count(); i++)
        {
            if(dictionary.ContainsKey(nums2[i]))
            {
                if(answerDictionary.ContainsKey(nums2[i]))
                {
                    answerDictionary[nums2[i]]++;
                }
                else{
                    answerDictionary.Add(nums2[i], 1);
                }
            }
        }
        foreach(var x in answerDictionary)
        {
            answerList.Add(x.Key);
        }
        return answerList.ToArray();
    }
}
