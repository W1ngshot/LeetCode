using System.Collections;

namespace LeetCode._67._Add_Binary;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        int i = a.Length - 1, j = b.Length - 1, s = 0;
        var bitArr = new BitArray(Math.Max(a.Length, b.Length) + 1);
        var index = bitArr.Count;
        
        while (i >= 0 || j >= 0 || s == 1)
        {
            if (i >= 0)
                s += a[i--] - '0';
            if (j >= 0)
                s += b[j--] - '0';
            bitArr[--index] = s % 2 == 1;
            s /= 2;
        }

        return string.Create(bitArr.Length - index, bitArr, (span, bits) =>
        {
            for (var bit = 0; bit <  bitArr.Length - index; bit++)
                span[bit] = bits[bit + index] ? '1' : '0';
        });
    }
}