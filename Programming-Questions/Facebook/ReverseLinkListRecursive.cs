/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    ListNode start = new ListNode(-1);
    public ListNode ReverseList(ListNode head) {
        if(head == null)
            return null;
        var copy = start;
        var starting = ReverseHead(head);
        start.next = starting;
        start = start.next;
        start.next = null;
        copy = copy.next;
        return copy;
    }
    
    public ListNode ReverseHead(ListNode head)
    {
        if(head == null)
            return null;
        var newHead = ReverseHead(head.next);
        if(newHead != null)
        {
            start.next = newHead;
            start = start.next;
        }
        return head;
    }
}
