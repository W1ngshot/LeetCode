using LeetCode._1356._Sort_Integers_by_The_Number_of_1_Bits;

var solution = new Solution();

var nums = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
var ans = solution.SortByBits(nums);
Console.WriteLine(string.Join(" ", ans));