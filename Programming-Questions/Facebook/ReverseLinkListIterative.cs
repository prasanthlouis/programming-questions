/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        var list = new List<int>();
        var start = head;
        while(head != null)
        {
            list.Add(head.val);
            head = head.next;
        }
        head = start;
        for(int i = list.Count() - 1; i >= 0 ; i--)
        {
            start.val = list[i];
            start = start.next;
        }
        return head;
    }
}
