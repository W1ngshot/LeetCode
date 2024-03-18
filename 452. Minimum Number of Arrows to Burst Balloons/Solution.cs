namespace LeetCode._452._Minimum_Number_of_Arrows_to_Burst_Balloons;

public class Solution
{
    public int FindMinArrowShots(int[][] points)
    {
        points = points.OrderBy(x => x[1]).ToArray();
        var counter = 1;
        var minPoint = points[0];

        for (var i = 1; i < points.Length; i++)
        {
            if (points[i][0] > minPoint[1])
            {
                counter++;
                minPoint = points[i];
            }
        }

        return counter;
    }
}