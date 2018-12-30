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
    int longestPath = 0;
    public int LongestUnivaluePath(TreeNode root) {
        if(root == null)
            return 0;

        Recurse(root, root.val);
        return longestPath;
    }
    public int Recurse(TreeNode root, int previousValue)
    {
        if(root == null)
            return 0;
        
        int left = Recurse(root.left, root.val);
        int right = Recurse(root.right, root.val);
        longestPath = Math.Max(longestPath, left + right);
        if(root.val == previousValue)
            return Math.Max(left, right) + 1;
        return 0;
    }
}
