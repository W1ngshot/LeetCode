namespace LeetCode._1299._Replace_Elements_with_Greatest_Element_on_Right_Side;

public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {
        var max = arr[^1];
        arr[^1] = -1;
        for (var i = arr.Length - 2; i >= 0; i--)
        {
            var t = arr[i];
            arr[i] = max;
            if (t > max)
            {
                max = t;
            }
        }

        return arr;
    }
}