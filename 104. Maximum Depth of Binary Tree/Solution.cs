namespace LeetCode._104._Maximum_Depth_of_Binary_Tree;

//Definition for a binary tree node.
public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
{
    public int val = val;
    public TreeNode? left = left;
    public TreeNode? right = right;
}

public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        return root is null ? 0 : GetDepth(root, 1);
    }

    private int GetDepth(TreeNode node, int depth)
    {
        var left = node.left is null ? depth : GetDepth(node.left, depth + 1);
        var right = node.right is null ? depth : GetDepth(node.right, depth + 1);

        return Math.Max(left, right);
    }
}