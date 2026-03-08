using System.Text;

namespace LeetCode._1980._Find_Unique_Binary_String;

public class Solution
{
    public string FindDifferentBinaryString(string[] nums)
    {
        var sb = new StringBuilder();

        for (var i = 0; i < nums.Length; i++)
        {
            sb.Append(nums[i][i] == '0' ? '1' : '0');
        }
        
        return sb.ToString();
    }
}