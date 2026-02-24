using LeetCode._1022._Sum_of_Root_To_Leaf_Binary_Numbers;

var solution = new Solution();

var ll = new TreeNode();
var lr = new TreeNode(1);
var rl = new TreeNode();
var rr = new TreeNode(1);
var l = new TreeNode(0, ll, lr);
var r = new TreeNode(1, rl, rr);
var root = new TreeNode(1, l, r);

var ans = solution.SumRootToLeaf(root);
Console.WriteLine(string.Join(" ", ans));