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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        //TODO: understand this
        var list = new List<IList<int>>();
        var currentLevel = new Stack<TreeNode>();
        var nextLevel = new Stack<TreeNode>();
        currentLevel.Push(root);
        var innerList = new List<int>();
        
        while(currentLevel.Count() != 0)
        {
            var currentNode = currentLevel.Pop();
            if(currentNode == null)
                continue;
            innerList.Add(currentNode.val);
            if(currentNode.left != null)
            nextLevel.Push(currentNode.left);
            if(currentNode.right != null)
            nextLevel.Push(currentNode.right);
            if(currentLevel.Count() == 0)
            {
                list.Add(innerList);
                innerList = new List<int>();
                while(nextLevel.Count() != 0)
                {
                    currentLevel.Push(nextLevel.Pop());
                }
                nextLevel.Clear();
            }
        }
        return list;
        
    }
}
