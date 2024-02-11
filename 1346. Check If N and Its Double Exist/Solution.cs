namespace LeetCode._1346._Check_If_N_and_Its_Double_Exist;

public class Solution
{
    public bool CheckIfExist(int[] arr)
    {
        var hashes = new HashSet<int>();
        foreach (var el in arr)
        {
            if (el % 2 == 0 && hashes.TryGetValue(el / 2, out _) || hashes.TryGetValue(el * 2, out _))
            {
                return true;
            }

            hashes.Add(el);
        }

        return false;
    }
}