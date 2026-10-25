using System;
using System.Text;

namespace Labs
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Ընտրեք լաբը (1-4)՝");
            switch (Console.ReadLine())
            {
                case "1": Lab1.Main1(); break;
                case "2": Lab2.Main2(); break;
                case "3": Lab3.Main3(); break;
                case "4": Lab4.Main4(); break;
                default: Console.WriteLine("Սխալ ընտրություն"); break;
            }
        }
    }
}
