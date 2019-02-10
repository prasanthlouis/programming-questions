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
    int answer = int.MinValue;
    public int MaxPathSum(TreeNode root) {
        var max = Recurse(root);
        Console.WriteLine(max);
        if(max > answer)
            answer = max;
        return answer;
    }
    
    public int Recurse(TreeNode root)
    {
        if(root == null)
            return 0;
        
        var left = Recurse(root.left);
        var right = Recurse(root.right);
        var subMax = left + right + root.val;
        if(subMax > answer)
            answer = subMax;
        var max = Math.Max(root.val, root.val + Math.Max(left,right));
        if(max > answer)
            answer = max;
        return max;
    }
}
