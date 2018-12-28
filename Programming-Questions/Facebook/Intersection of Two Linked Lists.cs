/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        int headAFinished = 0;
        int headBFinished = 0;
        var copyA = headA;
        var copyB = headB;
        while(headAFinished < 2 && headBFinished < 2)
        {
            if(headA == headB)
            {
                return headA;
            }
            else{
                headA = headA?.next;
                headB = headB?.next;
            }
            if(headA == null)
            {
                headA = copyB;
                headAFinished++;
            }
            if(headB == null)
            {
                headB = copyA;
                headBFinished++;
            }
        }
        return null;   
    }
}
