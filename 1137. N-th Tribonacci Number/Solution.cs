namespace LeetCode._1137._N_th_Tribonacci_Number;

public class Solution
{
    public int Tribonacci(int n)
    {
        int f = 0, s = 1, t = 1;

        switch (n)
        {
            case 0:
                return 0;
            case 1 or 2:
                return 1;
            default:
                for (var i = 3; i <= n; i++)
                {
                    (f, s, t) = (s, t, f + s + t);
                }

                return t;
        }
    }
}