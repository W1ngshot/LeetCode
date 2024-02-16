namespace LeetCode._66._Plus_One;

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        var list = new List<int>();
        var isPlus = true;
        for (var i = digits.Length - 1; i >= 0; i--)
        {
            if (isPlus)
            {
                list.Add((digits[i] + 1) % 10);
                isPlus = digits[i] == 9;
            }
            else
            {
                list.Add(digits[i]);
            }
        }

        if (list.Last() == 0)
        {
            list.Add(1);
        }

        list.Reverse();
        return list.ToArray();
    }
}