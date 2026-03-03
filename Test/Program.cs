using LeetCode._1545._Find_Kth_Bit_in_Nth_Binary_String;

var solution = new Solution();

var n = 3;
var k = 7;
var ans = new List<char>();
for (var i = 1; i <= k; i++)
{
    ans.Add(solution.FindKthBit(n, i));
}
Console.WriteLine(string.Join(" ", ans));