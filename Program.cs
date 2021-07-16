using System;

namespace onelab
{
    class Program
    {
        static int N;
        static int[] board;
        static void PrintPlaced()
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


        static void QueensSolution(int x)
        {
            for (int i = 1; i <= N; i++)
            {
                if (Placement(x, i))
                {
                    board[x] = i;
                    if (x == N)
                    {
                        PrintPlaced();
                    }
                    else QueensSolution(x + 1);
                }

            }

        }


        static void Main(string[] args)
        {
            N = 8;
            board = new int[N+1];
            QueensSolution(1);
            Console.ReadLine();
        }
    }
}
