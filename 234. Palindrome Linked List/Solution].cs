namespace LeetCode._234._Palindrome_Linked_List;

//Definition for singly-linked list.
public class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;
    public ListNode? next = next;
}

public class Solution
{
    public bool IsPalindrome(ListNode head)
    {
        var current = head;
        var stack = new Stack<ListNode>();
        var counter = 0;
        while (current is not null)
        {
            stack.Push(current);
            current = current.next;
            counter++;
        }

        current = head;
        for (var i = 0; i < counter / 2; i++)
        {
            if (current!.val != stack.Pop().val)
                return false;
            current = current.next;
        }

        return true;
    }
}