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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        return Helper(preorder, inorder).Item1;
    }
    
    public Tuple<TreeNode, int[]> Helper(int[] preorder, int[] inorder){
        if(inorder.Count() == 0)
        {
            return new Tuple<TreeNode, int[]>(null, preorder);
        }
        var treeNode = new TreeNode(preorder[0]);
        var index = 0;
        while(index < inorder.Length && inorder[index] != preorder[0])
        {
            index++;
        }
        preorder = CopyOfRange(preorder, 1, preorder.Count());
        int[] leftInOrder = new int[inorder.Count()];
        int[] rightInOrder = new int[inorder.Count()];
        leftInOrder = CopyOfRange(inorder, 0, index);
        rightInOrder = index + 1 <= inorder.Count() ? CopyOfRange(inorder, index+1 , inorder.Count()) : new int[0];
        var p = Helper(preorder, leftInOrder);
        treeNode.left = p.Item1;
        preorder = p.Item2;
        var q = Helper(preorder, rightInOrder);
        treeNode.right = q.Item1;
        preorder = q.Item2;
        return new Tuple<TreeNode, int[]>(treeNode, preorder);
    }
    public int[] CopyOfRange(int[] src, int start, int end)
    {
        var length = end-start;
        var destination = new int[length];
        Array.Copy(src,start,destination,0, length);
        return destination;
    }
}
