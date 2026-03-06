namespace LeetCode._1784._Check_if_Binary_String_Has_at_Most_One_Segment_of_Ones;

public class Solution
{
    public bool CheckOnesSegment(string s)
    {
        var isEnded = false;
        foreach (var ch in s)
        {
            switch (ch)
            {
                case '0':
                    isEnded = true;
                    break;
                case '1' when isEnded:
                    return false;
            }
        }

        return true;
    }
}