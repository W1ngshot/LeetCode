using LeetCode._104._Maximum_Depth_of_Binary_Tree;

var solution = new Solution();

var l = new TreeNode(9);
var rl = new TreeNode(15);
var rr = new TreeNode(7);
var r = new TreeNode(20, rl, rr);
var root = new TreeNode(3, l, r);

var ans = solution.MaxDepth(root);
Console.WriteLine(string.Join(" ", ans));