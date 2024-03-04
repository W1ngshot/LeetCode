namespace LeetCode._948._Bag_of_Tokens;

public class Solution
{
    public int BagOfTokensScore(int[] tokens, int power)
    {
        Array.Sort(tokens);
        var score = 0;
        int l = 0, r = tokens.Length - 1;
        while (l <= r)
        {
            if (power >= tokens[l])
            {
                power -= tokens[l++];
                score++;
            }
            else if (tokens[r] > tokens[l] && score > 0)
            {
                power += tokens[r--];
                score--;
            }
            else
            {
                break;
            }
        }

        return score;
    }
}