using LeetCode._226._Invert_Binary_Tree;

var solution = new Solution();

var ll = new TreeNode(1);
var lr = new TreeNode(3);
var l = new TreeNode(2, ll, lr);
var rl = new TreeNode(6);
var rr = new TreeNode(9);
var r = new TreeNode(7, rl, rr);
var root = new TreeNode(4, l, r);

var ans = solution.InvertTree(root);
Console.WriteLine(string.Join(" ", ans));