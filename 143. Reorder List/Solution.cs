namespace LeetCode._143._Reorder_List;

// Definition for singly-linked list.
public class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;
    public ListNode? next = next;
}

public class Solution
{
    public void ReorderList(ListNode head)
    {
        ListNode slow = head, fast = head.next;

        while (fast?.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }

        ListNode left = head, right = slow.next;
        slow.next = null;

        ListNode prev = null, curr = right;
        while (curr is not null)
        {
            var next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        right = prev;

        while (right is not null)
        {
            ListNode l = left.next, r = right.next;
            left.next = right;
            right.next = l;

            left = l;
            right = r;
        }
    }
}