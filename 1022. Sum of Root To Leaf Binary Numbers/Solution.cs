namespace LeetCode._1022._Sum_of_Root_To_Leaf_Binary_Numbers;

public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
{
    public int val = val;
    public TreeNode? left = left;
    public TreeNode? right = right;
}

public class Solution
{
    public int SumRootToLeaf(TreeNode root)
    {
        var sum = 0;

        var stack = new Stack<(TreeNode Node, int Value)>();
        stack.Push((root, root.val));

        while (stack.Count > 0)
        {
            var tuple = stack.Pop();
            
            if (tuple.Node.left == null && tuple.Node.right == null)
            {
                sum += tuple.Value;
                continue;
            }

            if (tuple.Node.right != null)
                stack.Push((tuple.Node.right, (tuple.Value << 1) | tuple.Node.right.val));

            if (tuple.Node.left != null)
                stack.Push((tuple.Node.left, (tuple.Value << 1) | tuple.Node.left.val));
        }

        return sum;
    }
}