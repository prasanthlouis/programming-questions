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
    int i = 0;
    List<int> answerList = new List<int>();
    public IList<int> FlipMatchVoyage(TreeNode root, int[] voyage) {
        var answer = Recurse(root, voyage);
        if(answer == false)
            return new List<int>(){-1};
        return answerList;
    }
    
    public bool Recurse(TreeNode root, int[] voyage)
    {
        if(root == null)
            return true;
        if(root.val != voyage[i++])
            return false;
        if(root.left != null && root.left.val != voyage[i])
        {
                answerList.Add(root.val);
                return Recurse(root.right, voyage) && Recurse(root.left,voyage);
        }

        return Recurse(root.left, voyage) && Recurse(root.right,voyage);
    }
    

}
