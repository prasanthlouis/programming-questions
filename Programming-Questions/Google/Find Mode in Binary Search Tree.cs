/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    Dictionary<int, int> dict = new Dictionary<int, int>();
    public int[] FindMode(TreeNode root) {
        Recurse(root);
        var maxOccurance = 0;
        var answer = new List<int>();
        foreach(var x in dict)
        {
            if(x.Value >= maxOccurance)
            {
                maxOccurance = x.Value;
            }
        }
        foreach(var x in dict)
        {
            if(x.Value == maxOccurance)
            {
                answer.Add(x.Key);
            }
        }
        return answer.ToArray();
    }
    public void Recurse(TreeNode root)
    {
        if(root == null)
            return;
        Recurse(root.left);
        if(dict.ContainsKey(root.val))
            dict[root.val]++;
        else
        dict.Add(root.val, 1);
        Recurse(root.right);
    }
}
