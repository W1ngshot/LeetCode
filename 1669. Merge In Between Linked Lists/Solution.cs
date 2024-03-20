namespace LeetCode._1669._Merge_In_Between_Linked_Lists;

//Definition for singly-linked list.
public class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;
    public ListNode? next = next;
}

public class Solution
{
    public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2)
    {
        var result = new ListNode
        {
            next = list1
        };
        var first = result;

        for (var i = 0; i < a; i++)
        {
            first = first!.next;
        }

        var second = first!.next;
        for (var i = a; i <= b; i++)
        {
            second = second!.next;
        }

        first!.next = list2;

        while (list2.next != null)
        {
            list2 = list2.next;
        }

        list2.next = second;

        return result.next;
    }
}