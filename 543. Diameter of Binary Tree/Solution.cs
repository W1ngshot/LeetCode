namespace LeetCode._543._Diameter_of_Binary_Tree;

//Definition for a binary tree node.
public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
{
    public int val = val;
    public TreeNode? left = left;
    public TreeNode? right = right;
}

public class Solution
{
    public int DiameterOfBinaryTree(TreeNode? root) => CalculateNode(root).Item2;

    private Tuple<int, int> CalculateNode(TreeNode? node)
    {
        if (node is null)
            return new(0, 0);

        var left = CalculateNode(node.left);
        var right = CalculateNode(node.right);

        var height = 1 + Math.Max(left.Item1, right.Item1);
        var diameter = Math.Max(Math.Max(left.Item2, right.Item2), left.Item1 + right.Item1);
        
        return new(height, diameter);
    }
}