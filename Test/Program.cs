using LeetCode._3070._Count_Submatrices_with_Top_Left_Element_and_Sum_Less_Than_k;

var solution = new Solution();

int[][] matrix = [[7,2,9],[1,5,0],[2,6,6]];
var ans = solution.CountSubmatrices(matrix, 20);
Console.WriteLine(string.Join(' ', ans));