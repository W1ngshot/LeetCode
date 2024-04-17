namespace LeetCode._988._Smallest_String_Starting_From_Leaf;

//Definition for a binary tree node.
public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
{
    public int val = val;
    public TreeNode? left = left;
    public TreeNode? right = right;
}

public class Solution
{
    public string SmallestFromLeaf(TreeNode root)
    {
        var queue = new Queue<(TreeNode, string)>();
        queue.Enqueue((root, ((char)(root.val + 'a')).ToString()));

        var result = "";
        
        while (queue.TryDequeue(out var tuple))
        {
            var node = tuple.Item1;

            if (node.left is null && node.right is null)
            {
                if (result == "" || tuple.Item2.CompareTo(result) < 0)
                    result = tuple.Item2;
            }
            
            if (node.left is not null)
                queue.Enqueue((node.left, (char)(node.left.val + 'a') + tuple.Item2));
            
            if (node.right is not null)
                queue.Enqueue((node.right, (char)(node.right.val + 'a') + tuple.Item2));
        }

        return result;
    }
}