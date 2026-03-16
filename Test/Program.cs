using LeetCode._1878._Get_Biggest_Three_Rhombus_Sums_in_a_Grid;

var solution = new Solution();

int[][] grid = [[3, 4, 5, 1, 3], [3, 3, 4, 2, 3], [20, 30, 200, 40, 10], [1, 5, 5, 4, 1], [4, 3, 2, 2, 5]];
var ans = solution.GetBiggestThree(grid);
Console.WriteLine(string.Join(' ', ans));