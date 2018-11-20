/**
 * Definition for undirected graph.
 * public class UndirectedGraphNode {
 *     public int label;
 *     public IList<UndirectedGraphNode> neighbors;
 *     public UndirectedGraphNode(int x) { label = x; neighbors = new List<UndirectedGraphNode>(); }
 * };
 */
public class Solution {
            Dictionary<UndirectedGraphNode, UndirectedGraphNode> dictionary = new Dictionary<UndirectedGraphNode, UndirectedGraphNode>();
    public UndirectedGraphNode CloneGraph(UndirectedGraphNode node) {
        var random  = CopyList(node);
        return random;
    }
    public UndirectedGraphNode CopyList(UndirectedGraphNode node)
    {
        if(node == null)
            return null;
        
        if(dictionary.ContainsKey(node))
            return dictionary[node];
        var newNode = new UndirectedGraphNode(node.label);
        dictionary[node] = newNode;
        foreach(var neighbor in node.neighbors)
        {
            newNode.neighbors.Add(CopyList(neighbor));
        }
        return newNode;
    }
}
