namespace LeetCode._1171._Remove_Zero_Sum_Consecutive_Nodes_from_Linked_List;

//Definition for singly-linked list.

public class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;
    public ListNode? next = next;
}

public class Solution
{
    public ListNode RemoveZeroSumSublists(ListNode head)
    {
        var dict = new Dictionary<int, ListNode>();
        var sum = 0;
        var start = new ListNode(0, head);

        var current = start;
        while (current is not null)
        {
            sum += current.val;
            dict[sum] = current;
            current = current.next;
        }

        current = start;
        sum = 0;

        while (current is not null)
        {
            sum += current.val;
            current.next = dict[sum].next;
            current = current.next;
        }

        return start.next!;
    }
}