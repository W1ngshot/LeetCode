namespace LeetCode._42._Trapping_Rain_Water;

public class Solution
{
    public int Trap(int[] height)
    {
        var n = height.Length;
        int left = 0, right = n - 1;
        int lMax = 0, rMax = 0;
        var counter = 0;

        while (left < right)
        {
            if (height[left] < height[right])
            {
                if (height[left] >= lMax)
                    lMax = height[left++];
                else
                    counter += lMax - height[left++];
            }
            else
            {
                if (height[right] >= rMax)
                    rMax = height[right--];
                else
                    counter += rMax - height[right--];
            }
        }

        return counter;
    }
}