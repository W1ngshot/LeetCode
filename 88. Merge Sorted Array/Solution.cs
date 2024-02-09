namespace LeetCode._88._Merge_Sorted_Array;

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var i = m - 1;
        var j = n - 1;
        var res = m + n - 1;

        while (j >= 0)
        {
            if (i >= 0 && nums1[i] > nums2[j])
            {
                nums1[res--] = nums1[i--];
            }
            else
            {
                nums1[res--] = nums2[j--];
            }
        }
    }
}