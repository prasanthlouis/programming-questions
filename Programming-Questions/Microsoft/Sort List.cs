/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SortList(ListNode head) {
        if(head == null || head.next == null)
        {
            return head;
        }
        ListNode previous = null;
        var slow = head;
        var fast = head;
        while(fast != null && fast.next != null)
        {
            previous = slow;
            slow = slow.next;
            fast = fast.next.next;
        }
        
        previous.next = null;
        
       Console.WriteLine($"{previous.val} {slow.val}");
        var l1 = SortList(head);
        var l2 = SortList(slow);
        
        return MergeSort(l1,l2);
    }
    
    public ListNode MergeSort(ListNode l1, ListNode l2)
    {
        var listNode = new ListNode(0);
        var p = listNode;
        while(l1 != null && l2 != null)
        {
            if(l1.val < l2.val)
            {
                p.next = l1;
                l1 = l1.next;
                
            }
            else{
                p.next = l2;
                l2 = l2.next;
            }
            p = p.next;
        }
        if(l1 != null)
        {
            p.next = l1;
        }
        if(l2 != null) {
            p.next = l2;
        }
        return listNode.next;       
    }
}
