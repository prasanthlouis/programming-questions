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
    int r = 0;
    public int DistributeCoins(TreeNode root) {
        
        Recurse(root);
        return r;
    }
    
    public int Recurse(TreeNode root)
    {
        if(root == null)
            return 0;
        
        var left = Recurse(root.left);
        var right = Recurse(root.right);
        r += Math.Abs(left) + Math.Abs(right);
        return root.val + left + right - 1;
    }
}
