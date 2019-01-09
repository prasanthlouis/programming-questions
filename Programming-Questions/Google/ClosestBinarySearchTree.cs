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
    public int ClosestValue(TreeNode root, double target) {
        if(root == null)
            return -1;
        
        if(root.left == null & root.right == null)
            return root.val;
        
        var valu = root.val;
        while(root != null)
        {
            if(Math.Abs(target - root.val) < Math.Abs(target - valu))
                valu = root.val;
            
            if(root.val < target)
                root = root.right;
            else
                root = root.left;
        }
        return valu;

    }
    
}
