namespace LeetCode._58._Length_of_Last_Word;

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        return s.TrimEnd().Split(' ')[^1].Length;
    }
}