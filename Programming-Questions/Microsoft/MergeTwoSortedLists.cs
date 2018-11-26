/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        var dummyNode = new ListNode(0);
        var current = dummyNode;
        while(l1 != null || l2 != null)
        {
            var value1 = (l1 != null) ? l1.val : int.MaxValue;
            var value2 = (l2 != null) ? l2.val : int.MaxValue;
            if(value1 >= value2)
            {
             current.next = l2;
             l2 = l2.next;
            }
            else{
                current.next = l1;
        l1 = l1.next;
            }
             current = current.next;
            
        }
        return dummyNode.next;
    }
}
