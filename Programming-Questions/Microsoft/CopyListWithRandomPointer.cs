/**
 * Definition for singly-linked list with a random pointer.
 * public class RandomListNode {
 *     public int label;
 *     public RandomListNode next, random;
 *     public RandomListNode(int x) { this.label = x; }
 * };
 */
public class Solution {
                  Dictionary<RandomListNode, RandomListNode> dictionary = new Dictionary<RandomListNode, RandomListNode>();
    public RandomListNode CopyRandomList(RandomListNode head) {
      var node = CopyList(head);
        return node;
    }
    
    public RandomListNode CopyList(RandomListNode head){
        if(head == null)
            return null;
        if(dictionary.ContainsKey(head))
        {
            return dictionary[head];
        }
        var node = new RandomListNode(head.label);
        
        dictionary[head] = node;
        node.next = CopyList(head.next);
        node.random = CopyList(head.random);
        return node;
    }
}
