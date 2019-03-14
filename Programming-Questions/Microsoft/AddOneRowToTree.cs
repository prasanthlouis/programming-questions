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
    public TreeNode AddOneRow(TreeNode root, int v, int d) {
        if(d == 1)
        {
            var node = new TreeNode(v);
            node.left = root;
            return node;
        }
        return Recurse(root, v, d, 1);
        
    }
    
    public TreeNode Recurse(TreeNode root, int v, int d, int currentLevel)
    {
        if(root == null)
            return null;
        
        if(d == currentLevel + 1)
        {
            var leftNode = new TreeNode(v);
            var rightNode = new TreeNode(v);
            var temp = root.left;
            root.left = leftNode;
            leftNode.left = temp;
            temp = root.right;
            root.right = rightNode;
            rightNode.right = temp;
            return root;
        }
        
       Recurse(root.left, v, d, currentLevel + 1);
       Recurse(root.right, v, d, currentLevel + 1);
       return root;
    }
}
