namespace LeetCode._169._Majority_Element;

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        while (true)
        {
            var randomElement = nums[Random.Shared.Next(0, nums.Length)];

            if (nums.Count(x => x == randomElement) > nums.Length / 2)
                return randomElement;
        }
    }
}