namespace LeetCode._226._Invert_Binary_Tree;

//Definition for a binary tree node.
public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
{
    public int val = val;
    public TreeNode? left = left;
    public TreeNode? right = right;
}

public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root is null)
            return root;

        var queue = new Queue<TreeNode?>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (node is null)
                continue;

            (node.left, node.right) = (node.right, node.left);

            queue.Enqueue(node.left);
            queue.Enqueue(node.right);
        }

        return root;
    }
}