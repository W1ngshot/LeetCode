namespace LeetCode._79._Word_Search;

public class Solution
{
    public bool Exist(char[][] board, string word)
    {
        for (var i = 0; i < board.Length; i++)
        {
            for (var j = 0; j < board[0].Length; j++)
            {
                if (IsFound(board, word, i, j, 0))
                    return true;
            }
        }

        return false;
    }

    private static bool IsFound(char[][] board, string word, int row, int column, int index)
    {
        if (index == word.Length)
            return true;

        if (row < 0 || row >= board.Length || column < 0 || column >= board[0].Length ||
            board[row][column] != word[index])
            return false;

        var value = board[row][column];
        board[row][column] = '-';

        var isFound = IsFound(board, word, row - 1, column, index + 1) ||
                      IsFound(board, word, row + 1, column, index + 1) ||
                      IsFound(board, word, row, column - 1, index + 1) ||
                      IsFound(board, word, row, column + 1, index + 1);

        board[row][column] = value;
        return isFound;
    }
}