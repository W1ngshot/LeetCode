using LeetCode._1582._Special_Positions_in_a_Binary_Matrix;

var solution = new Solution();

var n = new[]
{
    new[] { 1, 0, 0 },
    new[] { 0, 0, 1 },
    new[] { 1, 0, 0 }
};
var ans = solution.NumSpecial(n);
Console.WriteLine(string.Join(" ", ans));