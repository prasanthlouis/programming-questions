//Merge Sort
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        var nodes = new List<int>();
        if(lists.Count() == 0)
            return null;
        return Sort(lists, 0, lists.Count() - 1);
    }
    
    public ListNode Sort(ListNode[] lists, int low , int high)
    {
        if(low >= high)
            return lists[low];
        var mid = (low + high) / 2;
        var left  = Sort(lists, low, mid);
        var right = Sort(lists, mid + 1, high);
        return Merge(left, right);
    }
    
    public ListNode Merge(ListNode l1, ListNode l2)
    {
        if(l1 == null)
            return l2;
        if(l2 == null)
            return l1;
        
        if(l1.val < l2.val)
        {
            l1.next = Merge(l1.next, l2);
            return l1;
        }
        
        else{
            l2.next = Merge(l1, l2.next);
            return l2;
        }
    }
}


/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        var nodes = new List<int>();
        if(lists.Count() == 0)
            return null;
        foreach(var list in lists)
        {
            var start = list;
            while(start != null)
            {
                nodes.Add(start.val);
                start = start.next;
            }
        }
        nodes.Sort();
        var dummyNode = new ListNode(-1);
        var answerStart = dummyNode;
        for(int i = 0 ;i < nodes.Count(); i++)
        {
            var node = new ListNode(nodes[i]);
            dummyNode.next = node;
            dummyNode = dummyNode.next;
        }
        return answerStart.next;
    }
}
