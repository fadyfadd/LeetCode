using System;
namespace LeetCode
{
	public class ValidSoduku
	{
        public bool IsValidSudoku(char[][] board)
        {

            Dictionary<char, int> lookup = new Dictionary<char, int>();


            for (int y = 0; y < 9; y++)
            {
                lookup.Clear();
                for (int x = 0; x < 9; x++)
                {
                    char c = board[y][x];
                    if (c == '.')
                        continue;

                    if (lookup.ContainsKey(c))
                    {
                        Console.WriteLine(c);
                        return false;
                    }

                    else
                        lookup.Add(c, 1);
                }
            }

            for (int x = 0; x < 9; x++)
            {
                lookup.Clear();
                for (int y = 0; y < 9; y++)
                {
                    char c = board[y][x];
                    if (c == '.')
                        continue;

                    if (lookup.ContainsKey(c))
                    {
                        return false;
                    }

                    else
                        lookup.Add(c, 1);
                }
            }


            if (ValideMatrixes(board, 0, 0, 3) == false)
                return false;

            if (ValideMatrixes(board, 0, 3, 3) == false)
                return false;

            if (ValideMatrixes(board, 0, 6, 3) == false)
                return false;

            if (ValideMatrixes(board, 3, 0, 3) == false)
                return false;

            if (ValideMatrixes(board, 3, 3, 3) == false)
                return false;

            if (ValideMatrixes(board, 3, 6, 3) == false)
                return false; ;

            if (ValideMatrixes(board, 6, 0, 3) == false)
                return false
                    ;
            if (ValideMatrixes(board, 6, 3, 3) == false)
                return false;

            if (ValideMatrixes(board, 6, 6, 3) == false)
                return false;

            return true;

        }

        public bool ValideMatrixes(char[][] board, int a, int b, int l)
        {

            Dictionary<char, int> lookup = new Dictionary<char, int>();

            for (int y = a; y < a + l; y++)
            {

                for (int x = b; x < b + l; x++)
                {
                    char c = board[y][x];
                    if (c == '.')
                        continue;

                    if (lookup.ContainsKey(c))
                    {

                        return false;
                    }

                    else
                        lookup.Add(c, 1);
                }
            }

            return true;
        }
    }
}

