public class Solution {
    public bool HasCycle(ListNode head) {
        if(head == null)
            return false;
        var dictionary = new Dictionary<ListNode,ListNode>();
        while(head != null)
        {
            if(dictionary.ContainsKey(head))
            {
                return true;
            }
            else{
                dictionary.Add(head,head);
            }
            head = head.next;
        }
        return false;
    }
}

//Constant space solution
public class Solution {
    public bool HasCycle(ListNode head) {
        if(head == null)
            return false;
        var slow = head;
        var fast = head.next;
        while(fast != slow)
        {
            if(fast == null || fast.next == null)
                return false;
            fast = fast.next.next;
            slow = slow.next;
        }
        return true;
    }
}

