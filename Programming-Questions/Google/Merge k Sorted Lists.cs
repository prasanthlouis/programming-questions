/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        var nodes = new List<int>();
        if(lists.Count() == 0)
            return null;
        foreach(var list in lists)
        {
            var start = list;
            while(start != null)
            {
                nodes.Add(start.val);
                start = start.next;
            }
        }
        nodes.Sort();
        var dummyNode = new ListNode(-1);
        var answerStart = dummyNode;
        for(int i = 0 ;i < nodes.Count(); i++)
        {
            var node = new ListNode(nodes[i]);
            dummyNode.next = node;
            dummyNode = dummyNode.next;
        }
        return answerStart.next;
    }
}
