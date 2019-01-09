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
        if(root == null)
            return true;
        
        if(root.left == null && root.right == null)
            return true;
        
        return Recurse(root, null, null);
    }
    
    public bool Recurse(TreeNode root, int? min, int? max)
    {
        var leftTree = true;
        var rightTree = true;
        if(root == null)
            return true;
        
        if(root.val >= max || root.val <= min)
        {
            return false;
        }
        
        if(root.left != null)
        {
            if(root.val <= root.left.val)
                return false;
            
        }
        if(root.right != null)
        {
            if(root.val >= root.right.val)
                return false;
        }
        
        if(root.left != null)
        {
             leftTree = Recurse(root.left, min, root.val);
        }
        
        if(root.right != null)
        {
             rightTree = Recurse(root.right, root.val, max);
        }
        
        return leftTree && rightTree;
    }
    
    
}
