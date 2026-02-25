namespace LeetCode._1356._Sort_Integers_by_The_Number_of_1_Bits;

public class Solution
{
    public int[] SortByBits(int[] arr)
    {
        Array.Sort(arr, (el1, el2) =>
        {
            var bits1 = int.PopCount(el1);
            var bits2 = int.PopCount(el2);
            
            return bits1 == bits2 ? el1 - el2 : bits1 - bits2;
        });
        
        return arr;
    }
}