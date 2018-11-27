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
    public bool IsValidBST(TreeNode root) {
        return Recurse(root, null, null);
    }
    
    public bool Recurse(TreeNode root, int? min, int? max)
    {
        if(root == null)
            return true;
        
        if((min != null && root.val <= min) || (max != null && root.val >= max))
            return false;
        
        return Recurse(root.left, min, root.val) && Recurse(root.right, root.val, max);
        
    }
}
