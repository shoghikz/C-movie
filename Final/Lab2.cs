using System;
using System.Text;

namespace Labs
{
    public static class Lab2
    {
        public static int ToMultiplicate(int x, int N = 2)
        {
            int sum = 0;
            for (int i = 0; i < N; i++)
                sum += x;
            return sum;
        }

        public static double ToMultiplicate(double x, int N = 2)
        {
            double sum = 0;
            for (int i = 0; i < N; i++)
                sum += x;
            return sum;
        }

        public static string ToMultiplicate(string x, int N = 2)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < N; i++)
                sb.Append(x);
            return sb.ToString();
        }

        public static void Main2()
        {
            Console.WriteLine(ToMultiplicate(5));
            Console.WriteLine(ToMultiplicate(5, 4));
            Console.WriteLine(ToMultiplicate(2.5));
            Console.WriteLine(ToMultiplicate(2.5, 3));
            Console.WriteLine(ToMultiplicate("ab"));
            Console.WriteLine(ToMultiplicate("ab", 3));
        }
    }
}
