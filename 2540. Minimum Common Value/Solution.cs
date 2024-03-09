namespace LeetCode._2540._Minimum_Common_Value;

public class Solution
{
    public int GetCommon(int[] nums1, int[] nums2)
    {
        int first = 0, second = 0;
        while (first < nums1.Length && second < nums2.Length)
        {
            if (nums1[first] == nums2[second])
                return nums1[first];
            
            if (nums1[first] < nums2[second])
                first++;
            else
                second++;
        }

        return -1;
    }
}