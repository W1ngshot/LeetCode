namespace LeetCode._2149._Rearrange_Array_Elements_by_Sign;

public class Solution
{
    public int[] RearrangeArray(int[] nums)
    {
        var res = new int[nums.Length];
        int p = 0, n = 1;
        foreach (var num in nums)
        {
            if (num > 0)
            {
                res[p] = num;
                p += 2;
            }
            else
            {
                res[n] = num;
                n += 2;
            }
        }

        return res;
    }
}