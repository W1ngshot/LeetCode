namespace LeetCode._27._Remove_Element;

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        var left = 0;
        var right = nums.Length - 1;
        var result = nums.Length;

        while (right >= left)
        {
            if (nums[right] == val)
            {
                result--;
                right--;
            }
            else if (nums[left] == val)
            {
                nums[left++] = nums[right--];
                result--;
            }
            else
            {
                left++;
            }
        }

        return result;
    }
}