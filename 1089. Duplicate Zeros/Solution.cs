namespace LeetCode._1089._Duplicate_Zeros;

public class Solution
{
    public void DuplicateZeros(int[] arr)
    {
        for (var i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == 0)
            {
                for (var j = arr.Length - 1; j > i; j--)
                {
                    arr[j] = arr[j - 1];
                }

                i++;
            }
        }
    }
}