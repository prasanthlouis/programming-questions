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
        var dummyNode = new ListNode(-1);
        dummyNode.next = head;
        int copyOfN = n;
        var fast = dummyNode;
        var slow = dummyNode;
        while(copyOfN >= 0)
        {
         fast = fast.next;
         copyOfN--;
        }
        while(fast != null)
        {
            slow = slow.next;
            fast = fast.next;
        }
        slow.next = slow.next.next;
        return dummyNode.next;
        
    }
}
