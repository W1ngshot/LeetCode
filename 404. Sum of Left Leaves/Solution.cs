namespace LeetCode._404._Sum_of_Left_Leaves;

//  Definition for a binary tree node.
public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
{
    public int val = val;
    public TreeNode? left = left;
    public TreeNode? right = right;
}

public class Solution
{
    public int SumOfLeftLeaves(TreeNode root)
    {
        var queue = new Queue<Tuple<TreeNode?, bool>>();
        queue.Enqueue(new (root, false));
        var sum = 0;

        while (queue.TryDequeue(out var tuple))
        {
            if (tuple.Item1 is null)
                continue;

            if (tuple.Item2 && tuple.Item1.left is null && tuple.Item1.right is null)
            {
                sum += tuple.Item1.val;
                continue;
            }
            
            queue.Enqueue(new (tuple.Item1.left, true));
            queue.Enqueue(new (tuple.Item1.right, false));
        }

        return sum;
    }
}