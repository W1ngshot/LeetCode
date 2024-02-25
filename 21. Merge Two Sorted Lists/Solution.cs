namespace LeetCode._21._Merge_Two_Sorted_Lists;

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
    public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        if (list1 is null && list2 is null)
            return null;
        var result = new List<int>();
        while (list1 is not null || list2 is not null)
        {
            if (list1 is null || (list2 is not null && list1.val > list2.val))
            {
                result.Add(list2.val);
                list2 = list2.next;
            }
            else
            {
                result.Add(list1.val);
                list1 = list1.next;
            }
        }

        var resultNode = new ListNode(result[0]);
        var currentNode = resultNode;
        for (var i = 1; i < result.Count; i++)
        {
            var node = new ListNode(result[i]);
            currentNode.next = node;
            currentNode = node;
        }

        return resultNode;
    }
}