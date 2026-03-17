using LeetCode._1727._Largest_Submatrix_With_Rearrangements;

var solution = new Solution();

int[][] matrix = [[1,1,0],[1,0,1]];
var ans = solution.LargestSubmatrix(matrix);
Console.WriteLine(string.Join(' ', ans));