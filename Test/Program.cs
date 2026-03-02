using LeetCode._1536._Minimum_Swaps_to_Arrange_a_Binary_Grid;

var solution = new Solution();

var n = new[]
{
        new []{1,1,1,0},
        new []{1,1,0,0},
        new []{1,0,0,0},
        new []{0,0,0,0},
};
var ans = solution.MinSwaps(n);
Console.WriteLine(string.Join(" ", ans));