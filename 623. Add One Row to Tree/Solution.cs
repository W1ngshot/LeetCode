namespace LeetCode._623._Add_One_Row_to_Tree;

//Definition for a binary tree node.
public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
{
    public int val = val;
    public TreeNode? left = left;
    public TreeNode? right = right;
}

public class Solution
{
    public TreeNode AddOneRow(TreeNode root, int val, int depth)
    {
        if (depth == 1)
            return new TreeNode(val, root);
        
        var queue = new Queue<(TreeNode?, int)>();
        queue.Enqueue((root, 1));

        while (queue.TryDequeue(out var tuple))
        {
            if (tuple.Item1 is null)
                continue;
            
            if (tuple.Item2 + 1 == depth)
            {
                var left = tuple.Item1.left;
                var right = tuple.Item1.right;

                var newLeft = new TreeNode(val, left);
                var newRight = new TreeNode(val, null, right);

                tuple.Item1.left = newLeft;
                tuple.Item1.right = newRight;
                
                continue;
            }
            
            queue.Enqueue((tuple.Item1.left, tuple.Item2 + 1));
            queue.Enqueue((tuple.Item1.right, tuple.Item2 + 1));
        }

        return root;
    }
}