namespace LeetCode._412._Fizz_Buzz;

public class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        var result = new List<string>();
        for (var x = 1; x <= n; x++)
        {
            result.Add(x % 15 == 0 ? "FizzBuzz" :
                x % 3 == 0 ? "Fizz" :
                x % 5 == 0 ? "Buzz" : x.ToString());
        }

        return result;
    }
}