namespace LeetCode._1609._Even_Odd_Tree;

//Definition for a binary tree node.
public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
{
    public int val = val;
    public TreeNode? left = left;
    public TreeNode? right = right;
}

public class Solution
{
    public bool IsEvenOddTree(TreeNode root)
    {
        var queue = new Queue<Tuple<TreeNode, int>>();
        queue.Enqueue(new (root, 0));
        var currentTuple = new Tuple<int, int>(0, -1);
        
        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            if (current.Item2 % 2 == current.Item1.val % 2)
                return false;
            
            if (current.Item2 != currentTuple.Item2)
            {
                currentTuple = new (current.Item1.val, current.Item2);
                EnqueueNodes(current, queue);
                continue;
            }
            
            if (current.Item2 % 2 == 0 && current.Item1.val <= currentTuple.Item1 ||
                current.Item2 % 2 == 1 && current.Item1.val >= currentTuple.Item1)
            {
                return false;
            }

            currentTuple = new(current.Item1.val, current.Item2);
            EnqueueNodes(current, queue);
        }

        return true;
    }

    private void EnqueueNodes(Tuple<TreeNode, int> node, Queue<Tuple<TreeNode, int>> queue)
    {
        if (node.Item1.left is not null)
            queue.Enqueue(new (node.Item1.left, node.Item2 + 1));
        if (node.Item1.right is not null)
            queue.Enqueue(new (node.Item1.right, node.Item2 + 1));
    }
}