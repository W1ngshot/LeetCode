using LeetCode._101._Symmetric_Tree;

var solution = new Solution();

var ll = new TreeNode(3);
var lr = new TreeNode(4);
var l = new TreeNode(2, ll, lr);
var rl = new TreeNode(4);
var rr = new TreeNode(3);
var r = new TreeNode(2, rl, rr);
var root = new TreeNode(1, l, r);

var ans = solution.IsSymmetric(root);
Console.WriteLine(string.Join(" ", ans));