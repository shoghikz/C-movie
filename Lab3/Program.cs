using System;
using System.Text;

namespace Lab3
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Մուտքագրեք ֆիլմերի քանակը՝");
            int count = int.Parse(Console.ReadLine());

            Movie[] movies = new Movie[count];

            Console.WriteLine("Ֆորմատ՝ համար,անուն,տարեթիվ,ժանր(1-5),դիտումներ,լայքեր");
            Console.WriteLine("Օրինակ՝ 1,Inception,2010,5,1500000,900000");
            for (int i = 0; i < count; i++)
            {
                string[] p = Console.ReadLine().Split(',');
                movies[i] = new Movie
                {
                    Id = int.Parse(p[0].Trim()),
                    Name = p[1].Trim(),
                    Year = int.Parse(p[2].Trim()),
                    Genre = (Genre)int.Parse(p[3].Trim()),
                    Views = long.Parse(p[4].Trim()),
                    Likes = long.Parse(p[5].Trim())
                };
            }

            Console.WriteLine();
            foreach (Movie m in movies)
                Console.WriteLine(m);
        }
    }
}