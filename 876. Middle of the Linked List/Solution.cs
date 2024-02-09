namespace LeetCode._876._Middle_of_the_Linked_List;

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
    public ListNode MiddleNode(ListNode head)
    {
        var middle = head;
        var last = head;

        var counter = 0;
        while (last.next != null)
        {
            last = last.next;
            if (counter % 2 == 0)
            {
                middle = middle.next;
            }

            counter++;
        }

        return middle;
    }
}