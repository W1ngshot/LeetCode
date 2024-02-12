namespace LeetCode._941._Valid_Mountain_Array;

public class Solution
{
    public bool ValidMountainArray(int[] arr)
    {
        if (arr.Length < 3 || arr[0] >= arr[1])
        {
            return false;
        }

        var inc = true;
        var last = arr[0];
        for (var i = 1; i < arr.Length; i++)
        {
            if (inc && arr[i] <= last)
            {
                inc = !inc;
            }

            if (!inc && arr[i] >= last)
            {
                return false;
            }

            last = arr[i];
        }

        return !inc;
    }
}