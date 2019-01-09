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
    public int ClosestValue(TreeNode root, double target) {
        if(root == null)
            return -1;
        
        if(root.left == null & root.right == null)
            return root.val;
        Recurse(root);
        list.Sort();
        
        if(target == list[0])
            return list[0];
        for(int i =1 ; i < list.Count(); i++)
        {
            if(target == list[i])
                return list[i];
            
            if(target < list[i] && target > list[i-1])
            {
                var result1 = list[i] - target;
                var result2 = target - list[i-1];
                if(result1 - result2 > 0)
                {  
                    return list[i-1];
                }
                else{
                    return list[i];
                }
            }
        }
        
        if(target > list[list.Count() - 1])
            return list[list.Count() - 1];
           else{
               return list[0];
           }
    }
    
    public void Recurse(TreeNode root)
    {
        if(root == null)
            return;
        
        list.Add(root.val);
        
        Recurse(root.left);
        Recurse(root.right);
        return;
    }
}
