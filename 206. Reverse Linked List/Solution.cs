namespace LeetCode._206._Reverse_Linked_List;

//Definition for singly-linked list.
public class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;
    public ListNode? next = next;
}

public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        if (head is null || head.next is null)
            return head;
        var current = head.next;
        var prev = head;
        prev.next = null;

        while (current is not null)
        {
            var next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }
}