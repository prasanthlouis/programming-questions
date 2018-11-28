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
        List<int> list = new List<int>();
    public IList<int> InorderTraversal(TreeNode root) {
        Recurse(root);
        return list;
        
    }
    
    public TreeNode Recurse(TreeNode root)
    {
        if(root == null){
            return null;
        }
        
        if(root.left != null)
        {
            Recurse(root.left);
        }
        
        if(root != null)
        {
            list.Add(root.val);
        }
        
        if(root.right != null)
        {
            Recurse(root.right);
        }
        return null;
    }
}
