namespace LeetCode._290._Word_Pattern;

public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        var patternToWord = new Dictionary<char, string>();
        var wordToPattern = new Dictionary<string, char>();

        var span = s.AsSpan();
        var prevSpaceIndex = -1;
        var patternIndex = 0;

        for (var i = 0; i <= span.Length; i++)
        {
            if (i < span.Length && span[i] != ' ')
                continue;

            var word = span.Slice(prevSpaceIndex + 1, i - prevSpaceIndex - 1).ToString();
            if (patternIndex >= pattern.Length
                || (!patternToWord.TryAdd(pattern[patternIndex], word) && patternToWord[pattern[patternIndex]] != word)
                || (!wordToPattern.TryAdd(word, pattern[patternIndex]) && wordToPattern[word] != pattern[patternIndex]))
                return false;

            patternIndex++;
            prevSpaceIndex = i;
        }

        return patternIndex == pattern.Length;
    }
}