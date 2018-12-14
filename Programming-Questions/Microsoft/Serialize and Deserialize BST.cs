/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        if(root == null)
            return string.Empty;
        
        var stringBuilder = new StringBuilder();
        var str = Recurse(root, stringBuilder);
        str.Remove(str.Length - 1, 1);
        
        return str.ToString();
    }
    
    public StringBuilder Recurse(TreeNode root, StringBuilder sb)
    {
        if(root == null)
            return null;
        
        sb.Append(root.val);
        sb.Append(',');
        if(root.left != null)
        {
             sb = Recurse(root.left, sb);
        }
        if(root.right != null)
        {
            sb = Recurse(root.right, sb);
        }
        return sb;
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        if(string.IsNullOrWhiteSpace(data))
            return null;
        var nodes = data.Split(',').Select(x => int.Parse(x)).ToArray();
        int ri = 0;
        foreach(var n in nodes)
        {
            Console.Write(n);
        }
        Console.WriteLine();
        var node = Recursion(nodes, ref ri, int.MaxValue);
        
        return node;
    }
    
    public TreeNode Recursion(int[] nodes, ref  int  r, int maxValue)
    {
        var node = new TreeNode(nodes[r]);
        if(nodes.Count() == ++r)
        {
            return node;
        }
        if(nodes[r] <= node.val)
        {
           node.left =  Recursion(nodes,  ref r, node.val);
        }

        if(nodes.Count() == r)
        {
            return node;
        }
        if(nodes[r] > node.val && nodes[r] <= maxValue)
        {
           node.right = Recursion(nodes, ref r, maxValue);
        }
        
        return node;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));
