namespace LeetCode._19._Remove_Nth_Node_From_End_of_List;

//Definition for singly-linked list.
public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var size = 0;
        var current = head;
        while (current != null)
        {
            size++;
            current = current.next;
        }

        current = head;
        for (var i = 1; i < size; i++)
        {
            if (i == size - n)
                current.next = current.next?.next;
            current = current.next;
        }

        if (n == size)
            head = head.next;
        return head;
    }
}