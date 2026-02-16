namespace LeetCode._80._Remove_Duplicates_from_Sorted_Array_II;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        var pointer = 0;
        var currentNum = 0;
        var currentCounter = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (currentNum == nums[i])
            {
                currentCounter++;
                
                if (currentCounter > 2)
                    continue;
            }
            else
            {
                currentNum = nums[i];
                currentCounter = 1;
            }
            nums[pointer] = nums[i];
            pointer++;
        }

        return pointer;
    }
}