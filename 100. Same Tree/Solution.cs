namespace LeetCode._100._Same_Tree;

//Definition for a binary tree node.
public class TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
{
    public int val = val;
    public TreeNode left = left;
    public TreeNode right = right;
}

public class Solution
{
    public bool IsSameTree(TreeNode? p, TreeNode? q)
    {
        var first = new Queue<TreeNode?>();
        var second = new Queue<TreeNode?>();
        if (p is null && q is null)
            return true;
        if (p is null || q is null || p.val != q.val)
            return false;
        first.Enqueue(p);
        second.Enqueue(q);

        while (first.Count > 0 || second.Count > 0)
        {
            if (first.Count == 0 || second.Count == 0)
                return false;
            
            var f = first.Dequeue();
            var s = second.Dequeue();
            if (f?.val != s?.val)
                return false;
            if (f is null || s is null) continue;
            
            first.Enqueue(f.left);
            first.Enqueue(f.right);
            second.Enqueue(s.left);
            second.Enqueue(s.right);
        }

        return true;
    }
}