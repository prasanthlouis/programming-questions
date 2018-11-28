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
    TreeNode answer = null;
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        Recurse(root, p, q);
            return answer;
    }
    
    public bool Recurse(TreeNode root, TreeNode p, TreeNode q)
    {
        if(root == null)
            return false;
        
        var left = Recurse(root.left, p, q) ? 1 : 0;
        
        var right = Recurse(root.right, p, q) ? 1 : 0;
        
        var middle = (root == p || root == q) ? 1 : 0;
        if(left + right + middle >= 2)
        {
            answer = root;
            
        }
        return (left + right + middle > 0);
        
    }
}
