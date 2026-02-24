using LeetCode._290._Word_Pattern;

var solution = new Solution();

var pattern = "abba";
var s = "dog cat cat dog";
var ans = solution.WordPattern(pattern, s);
Console.WriteLine(string.Join(" ", ans));