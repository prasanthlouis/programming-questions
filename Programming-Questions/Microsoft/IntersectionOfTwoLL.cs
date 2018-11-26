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
        var countNullA = 0;
        var countNullB = 0;
        var startA = headA;
        var startB = headB;
        while(headA != headB)
        {
            if(headA == headB)
            {
                return headA;
            }
            if(headA == null)
            {
                countNullA++;
                headA = startB;
            }
            else{
                    headA = headA.next;
            }
            if(headB == null)
            {
                countNullB++;
                headB = startA;
            }
            else{
                 headB = headB.next;
            }
            if(countNullA == 2 || countNullB == 2)
            {
                return null;
            }       
        }
        if(headA == headB)
            return headA;
        else
            return null;
    }
}
