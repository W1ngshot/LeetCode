using System.Numerics;

namespace LeetCode._1622._Fancy_Sequence;

public class Fancy
{
    private readonly List<int> _numbers = [];
    private long _sum;
    private long _mult = 1;
    private const int Mod = 1_000_000_007;

    public void Append(int val)
    {
        var n = val - _sum;
        if (n < 0)
            n += Mod;
        var inverse = (long)BigInteger.ModPow(_mult, Mod - 2, Mod);
        var num = (int)(n * inverse % Mod);
        _numbers.Add(num);
    }

    public void AddAll(int inc)
    {
        _sum = (_sum + inc) % Mod;
    }

    public void MultAll(int m)
    {
        _sum = _sum * m % Mod;
        _mult = _mult * m % Mod;
    }

    public int GetIndex(int idx)
    {
        if (idx >= _numbers.Count)
            return -1;
        return (int)(((_numbers[idx] * _mult % Mod) + _sum) % Mod);
    }
}

/*
 * Your Fancy object will be instantiated and called as such:
 * Fancy obj = new Fancy();
 * obj.Append(val);
 * obj.AddAll(inc);
 * obj.MultAll(m);
 * int param_4 = obj.GetIndex(idx);
 */