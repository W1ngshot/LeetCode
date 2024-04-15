namespace LeetCode._129._Sum_Root_to_Leaf_Numbers;

//Definition for a binary tree node.
public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
{
    public int val = val;
    public TreeNode? left = left;
    public TreeNode? right = right;
}

public class Solution
{
    public int SumNumbers(TreeNode root)
    {
        var queue = new Queue<(TreeNode?, int)>();
        var counter = 0;

        queue.Enqueue((root, 0));
        while (queue.TryDequeue(out var tuple))
        {
            var node = tuple.Item1;
            if (node is null)
                continue;

            var sum = tuple.Item2 * 10 + node.val;
            if (node.left is null && node.right is null)
            {
                counter += sum;
                continue;
            }

            queue.Enqueue((node.left, sum));
            queue.Enqueue((node.right, sum));
        }

        return counter;
    }
}