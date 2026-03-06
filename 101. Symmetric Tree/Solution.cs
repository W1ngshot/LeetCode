namespace LeetCode._101._Symmetric_Tree;

//Definition for a binary tree node.
public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
{
    public int val = val;
    public TreeNode? left = left;
    public TreeNode? right = right;
}

public class Solution
{
    public bool IsSymmetric(TreeNode root)
    {
        if (root.left is null && root.left == root.right)
            return true;

        var leftQueue = new Queue<TreeNode?>();
        var rightQueue = new Queue<TreeNode?>();

        leftQueue.Enqueue(root.left);
        rightQueue.Enqueue(root.right);

        while (leftQueue.Count > 0 && rightQueue.Count > 0)
        {
            var leftQueueNode = leftQueue.Dequeue();
            var rightQueueNode = rightQueue.Dequeue();

            if (leftQueueNode?.val != rightQueueNode?.val)
                return false;

            if (leftQueueNode is null)
                continue;

            leftQueue.Enqueue(leftQueueNode.left);
            leftQueue.Enqueue(leftQueueNode.right);

            rightQueue.Enqueue(rightQueueNode!.right);
            rightQueue.Enqueue(rightQueueNode.left);
        }

        return leftQueue.Count == rightQueue.Count;
    }
}