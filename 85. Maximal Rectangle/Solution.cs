namespace LeetCode._85._Maximal_Rectangle;

public class Solution
{
    public int MaximalRectangle(char[][] matrix)
    {
        var max = 0;
        var heights = new int[matrix[0].Length];

        foreach (var row in matrix)
        {
            for (var j = 0; j < matrix[0].Length; j++)
            {
                heights[j] = row[j] == '1' ? heights[j] + 1 : 0;
            }

            max = Math.Max(max, GetLargestRectangle(heights));
        }

        return max;
    }

    private int GetLargestRectangle(int[] heights)
    {
        var stack = new Stack<int>();
        int max = 0, index = 0;

        while (index < heights.Length)
        {
            if (stack.Count == 0 || heights[stack.Peek()] <= heights[index])
            {
                stack.Push(index++);
            }
            else
            {
                var element = stack.Pop();
                var area = heights[element] * (stack.Count == 0 ? index : index - stack.Peek() - 1);
                max = Math.Max(max, area);
            }
        }

        while (stack.Count > 0)
        {
            var element = stack.Pop();
            var area = heights[element] * (stack.Count == 0 ? index : index - stack.Peek() - 1);
            max = Math.Max(max, area);
        }

        return max;
    }
}