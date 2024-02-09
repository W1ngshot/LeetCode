namespace LeetCode._1342._Number_of_Steps_to_Reduce_a_Number_to_Zero;

public class Solution {
    public int NumberOfSteps(int num) {
        var count = 0;
        while (num > 0)
        {
            if (num % 2 == 0)
            {
                num /= 2;
            }
            else
            {
                num -= 1;
            }
            count++;
        }
        return count;
    }
}