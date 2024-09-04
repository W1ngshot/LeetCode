namespace LeetCode._94._Binary_Tree_Inorder_Traversal;

//Definition for a binary tree node.
public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
{
    public int val = val;
    public TreeNode? left = left;
    public TreeNode? right = right;
}

public class Solution
{
    private IList<int> resultList = new List<int>();
    
    public IList<int> InorderTraversal(TreeNode root)
    {
        if (root is null)
            return new List<int>();

        InorderTraversal(root.left);
        resultList.Add(root.val);
        InorderTraversal(root.right);

        return resultList;
    }
}