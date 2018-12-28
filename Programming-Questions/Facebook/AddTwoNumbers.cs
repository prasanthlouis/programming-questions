public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var start = new ListNode(-1);
        var copy = start;
        int carry = 0;
        while(l1 != null || l2 != null)
        {
            var value1 = l1 == null ? 0 : l1.val;
            var value2 = l2 == null ? 0 : l2.val;
            Console.WriteLine($"{value1} {value2} {carry}");
            var sum = (value1 + value2 + carry) % 10;
            carry = (value1 + value2 + carry) / 10;
            var newNode = new ListNode(sum);
            start.next = newNode;
            start = start.next; 
            if(l1 != null)
            l1 = l1.next;
            if(l2 != null)
            l2 = l2.next;
        }
        if(carry != 0)
        {
            var newNode = new ListNode(carry);
            start.next = newNode;
            start = start.next;
        }
        return copy.next;
    }
}
