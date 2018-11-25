/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    int carry = 0;
    ListNode prev = new ListNode(0);
    
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var length1 = 0;
        var length2 = 0;
        ListNode start = null;
        var h1 = l1;
        var h2 = l2;
        var count1 = CountLength(h1);
        var count2 = CountLength(h2);

        var diff = Math.Min(count1, count2);
        while(diff>0)
        {
            var sum = h1.val + h2.val + carry;
            var product = sum % 10;
            carry = sum / 10;
            var node = new ListNode(product);
            prev.next = node;
            prev = prev.next;
            if(start == null)
            {
                start = prev;
            }
            h1 = h1.next;
            h2 = h2.next;
            diff--;
        }
        if(count1 > count2)
        {
            int count = 0;
            diff = count1-count2;
            while(count < count1-count2)
            {
             var sum = h1.val + carry;
            var product = sum % 10;
            carry = sum / 10;
            var node = new ListNode(product);
            prev.next = node;
            prev = prev.next;
                h1=h1.next;
                count++;
            }
        }
        else if(count1 < count2){
            int count = 0;
            diff = count2-count1;
            while(count < count2-count1)
            {
             var sum =  h2.val + carry;
            var product = sum % 10;
            carry = sum / 10;
            var node = new ListNode(product);
            prev.next = node;
            prev = prev.next;
                h2=h2.next;
                count++;
            }
        }
        if(carry > 0)
        {
            prev.next = new ListNode(carry);
            prev = prev.next;
        }
        return start;
        
    }
    public int CountLength(ListNode h1)
    {
        var count1 = 1;
        while(h1.next != null)
        {
            count1++;
            h1 = h1.next;
        }
        return count1;
    }
}
