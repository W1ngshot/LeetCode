namespace LeetCode._1689._Partitioning_Into_Minimum_Number_Of_Deci_Binary_Numbers;

public class Solution
{
    public int MinPartitions(string n)
    {
        var max = 0;
        foreach (var ch in n)
        {
            if (max == '9')
                return 9;
            
            if (ch > max)
                max = ch;
        }

        return max - '0';
    }
}