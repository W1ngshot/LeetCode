namespace LeetCode._11._Container_With_Most_Water;

public class Solution
{
    public int MaxArea(int[] height)
    {
        var rPtr = height.Length - 1;
        var lPtr = 0;
        var result = 0;

        while (lPtr < rPtr)
        {
            var newAmount = Math.Min(height[lPtr],  height[rPtr]) * (rPtr - lPtr);
            result = Math.Max(result, newAmount);
            
            if (height[lPtr] < height[rPtr])
                lPtr++;
            else
                rPtr--;
        }
        
        return result;
    }
}