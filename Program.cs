using System;

namespace Telegram_Desktop
{
    class Program
    {
        static int N;
        static int[] board;
        static int cnt = 0;
        static void PrintPlaced(int[] board)
        {
            Console.WriteLine("--Solution--");
            Console.WriteLine();

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    if (board[i] != j) Console.Write("\t. ");
                    else Console.Write("\tQ ");

                }
                Console.Write("\n");
            }

        }



        // to check if queen can be placed
        static bool Placement(int start, int second)
        {
            for (int i = 1; i < start; i++)
            {
                if ((board[i] == second) || Math.Abs(board[i] - second) == Math.Abs(i - start))
                {
                    return false;
                }
            }
            return true;

        }


        static int Queens(int start, int amount)
        {
            for (int i = 1; i <= N; i++)
            {
                if (Placement(start, i))
                {
                    board[start] = i;
                    if (start == N)
                    {
                        cnt++;
                        PrintPlaced(board);
                    }
                    else Queens(start + 1, N);
                }

            }
            return cnt;

        }


        static void Main(string[] args)
        {
            N = 8;
            board = new int[100];
            var cnt = Queens(1, N);
            System.Console.WriteLine($"\n\n{cnt} answers.");
        }
    }
}
