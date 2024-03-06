namespace LeetCode._141._Linked_List_Cycle;

//Definition for singly-linked list.
public class ListNode(int x, ListNode? next)
{
    public int val = x;
    public ListNode? next = next;
}

public class Solution
{
    public bool HasCycle(ListNode head)
    {
        var hashSet = new HashSet<ListNode>();
        var current = head;
        while (current is not null)
        {
            if (!hashSet.Add(current))
                return true;
            current = current.next;
        }

        return false;
    }
}