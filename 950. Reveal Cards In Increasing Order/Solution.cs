namespace LeetCode._950._Reveal_Cards_In_Increasing_Order;

public class Solution
{
    public int[] DeckRevealedIncreasing(int[] deck)
    {
        Array.Sort(deck);
        var result = new int[deck.Length];
        var queue = new Queue<int>(Enumerable.Range(0, deck.Length));

        foreach (var card in deck)
        {
            result[queue.Dequeue()] = card;
            if (queue.Count > 0)
                queue.Enqueue(queue.Dequeue());
        }

        return result;
    }
}