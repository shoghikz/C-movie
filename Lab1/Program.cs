using System;
using System.Text;

namespace Lab1
{
    public class SquareMatrix
    {
        private int N { get; set; }
        private int A { get; set; }
        private int B { get; set; }

        private int[,] matrix;

        public SquareMatrix(int n, int a, int b)
        {
            N = n;
            A = a;
            B = b;
            FillMatrix();
        }

        private void FillMatrix()
        {
            matrix = new int[N, N];
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    matrix[i, j] = rnd.Next(A, B + 1);
        }

        public void ShowMatrix()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write($"{matrix[i, j],5}");
                Console.WriteLine();
            }
        }

        public int CountOdd()
        {
            int count = 0;
            foreach (int x in matrix)
                if (x % 2 != 0)
                    count++;
            return count;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            SquareMatrix m = new SquareMatrix(5, -10, 20);
            m.ShowMatrix();
            Console.WriteLine($"Կենտ թվերի քանակը՝ {m.CountOdd()}");
        }
    }
}