namespace LeetCode._2073._Time_Needed_to_Buy_Tickets;

public class Solution
{
    public int TimeRequiredToBuy(int[] tickets, int k)
    {
        var counter = 0;
        for (var i = 0; i < tickets.Length; i++)
        {
            if (i > k)
                counter += tickets[i] < tickets[k] ? tickets[i] : tickets[k] - 1;
            else
                counter += Math.Min(tickets[i], tickets[k]);
        }

        return counter;
    }
}