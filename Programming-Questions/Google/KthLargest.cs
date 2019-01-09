public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var list = new List<int>(nums);
        list.Sort();
        return list[list.Count() - k];
    }
}
