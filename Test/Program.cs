using LeetCode._219._Contains_Duplicate_II;

var solution = new Solution();

var nums = new[] { 1,2,3,4,5,6,7,8,9,10 };
var k = 15;
var ans = solution.ContainsNearbyDuplicate(nums, k);
Console.WriteLine(string.Join(" ", ans));