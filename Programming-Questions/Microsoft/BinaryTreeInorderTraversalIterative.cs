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
        var stack = new Stack<TreeNode>();
        while(root != null || stack.Count() != 0)
        {
            while(root != null)
            {
            stack.Push(root);
            root = root.left;
            }
            
            root = stack.Peek();
            stack.Pop();
            list.Add(root.val);
            root = root.right;
        }
        return list;     
    }
}
