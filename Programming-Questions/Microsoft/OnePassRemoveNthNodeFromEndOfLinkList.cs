/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var dummy = new ListNode(0);
        dummy.next =head;
        var start = dummy.next;
        var second = dummy;
        var tail = dummy;
        for(int i = 0;i<=n;i++)
        {
            tail = tail.next;
        }
        while(tail != null)
        {
            tail = tail.next;
            second = second.next;
        }
        second.next = second.next.next;
        return dummy.next;
    }
}
