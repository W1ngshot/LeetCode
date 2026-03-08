using LeetCode._1980._Find_Unique_Binary_String;

var solution = new Solution();

var nums = new[]
{
    "111", "011", "001"
};

var ans = solution.FindDifferentBinaryString(nums);
Console.WriteLine(string.Join(" ", ans));