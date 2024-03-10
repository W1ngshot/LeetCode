namespace LeetCode._349._Intersection_of_Two_Arrays;

public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        Array.Sort(nums1);
        Array.Sort(nums2);
        int first = 0, second = 0;
        var result = new HashSet<int>();

        while (first < nums1.Length && second < nums2.Length)
        {
            if (nums1[first] == nums2[second])
                result.Add(nums1[first]);
            if (nums1[first] > nums2[second])
                second++;
            else
                first++;
        }

        return result.ToArray();
    }
}