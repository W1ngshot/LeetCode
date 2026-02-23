using LeetCode._1461._Check_If_a_String_Contains_All_Binary_Codes_of_Size_K;

var solution = new Solution();

const string s = "11001";
const int k = 2;
var ans = solution.HasAllCodes(s, k);
Console.WriteLine(string.Join(" ", ans));