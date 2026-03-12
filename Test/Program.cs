using LeetCode._3600._Maximize_Spanning_Tree_Stability_with_Upgrades;

var solution = new Solution();

var ans = solution.MaxStability(6, new int[][]
{
    [0,1,7,1],[1,2,3,0],[2,3,8,0],[3,4,6,0],[4,5,5,0]
}, 1);
Console.WriteLine(string.Join(" ", ans));