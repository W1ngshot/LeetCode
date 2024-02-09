namespace LeetCode._2236._Root_Equals_Sum_of_Children;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public bool CheckTree(TreeNode root) =>
        root.val == root.left.val + root.right.val;
}