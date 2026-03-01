namespace LeetCode._2._Add_Two_Numbers;

//  Definition for singly-linked list.
public class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;
    public ListNode? next = next;
}

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var sum = (l1.val == null ? 0 : l1.val)
                  + (l2.val == null ? 0 : l2.val);

        if (sum > 9)
        {
            if (l1.next != null)
                l1.next.val++;
            else if (l2.next != null)
                l2.next.val++;
            else
                l1.next = new ListNode(1);
        }

        var node = new ListNode(sum % 10)
        {
            next = l1.next == null && l2.next == null ? null 
                : l1.next == null ? AddTwoNumbers(new ListNode(), l2.next) 
                : l2.next == null ? AddTwoNumbers(new ListNode(), l1.next)
                : AddTwoNumbers(l1.next, l2.next)
        };
        return node;
    }
}