using System;

namespace Labs
{
    public static class Lab4
    {
        public static void A(in int x)
        {
            Console.WriteLine($"A(in): ստացվեց {x}");
        }

        public static void B(out int result)
        {
            result = 42;
            Console.WriteLine("B(out): result-ին վերագրվեց 42");
        }

        public static void C(ref int x)
        {
            Console.WriteLine($"C(ref): մուտքում {x}");
            x *= 2;
        }

        public static int SumValues(params int[] values)
        {
            int sum = 0;
            foreach (int v in values)
                sum += v;
            return sum;
        }

        public static void Main4()
        {
            int a = 7;
            A(in a);                      

            B(out int b);                 
            Console.WriteLine($"b = {b}");

            int c = 5;
            C(ref c);
            Console.WriteLine($"C-ից հետո c = {c}"); 

            Console.WriteLine($"SumValues()          = {SumValues()}");
            Console.WriteLine($"SumValues(1,2,3)     = {SumValues(1, 2, 3)}");
            Console.WriteLine($"SumValues(1..6)      = {SumValues(1, 2, 3, 4, 5, 6)}");
            Console.WriteLine($"SumValues(massiv)    = {SumValues(new int[] { 10, 20, 30 })}");
        }
    }
}
