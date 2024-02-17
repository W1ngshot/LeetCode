namespace LeetCode._118._Pascal_s_Triangle;

public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        var resList = new List<IList<int>>();
        for (var i = 0; i < numRows; i++)
        {
            var list = new List<int>();
            for (var j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                {
                    list.Add(1);
                }
                else
                {
                    list.Add(resList[i - 1][j - 1] + resList[i - 1][j]);
                }
            }

            resList.Add(list);
        }

        return resList;
    }
}