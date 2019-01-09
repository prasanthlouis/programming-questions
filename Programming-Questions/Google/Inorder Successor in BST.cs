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
    TreeNode foundNode = null;
    Stack<TreeNode> stack = new Stack<TreeNode>();
    public TreeNode InorderSuccessor(TreeNode root, TreeNode p) {
        if(root.left == null && root.right == null)
            return null;
        TreeNode previousNode = null;
        Recurse(root, p);
        if(stack.Count > 0)
        {
            previousNode = stack.Pop();
            if(previousNode == p)
                return null;
        }
        while(stack.Count() > 0)
        {
            var currentNode = stack.Pop();
            if(currentNode == p)
                return previousNode;
            previousNode = currentNode;
        }
        return null;
    }
    
    public TreeNode Recurse(TreeNode root, TreeNode p)
    {
        if(root == null)
            return null;
        if(root.left != null)
        {
            Recurse(root.left, p);
        }
        
        stack.Push(root);
        
        if(root.right != null)
        {
            Recurse(root.right, p);
        }  
        
        return root;
    }
}
