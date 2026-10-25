using System;
using System.Globalization;

namespace Labs
{
    public enum Genre
    {
        Action = 1,
        Comedy = 2,
        Drama = 3,
        Horror = 4,
        SciFi = 5
    }

    public class Movie
    {
        public int Id;
        public string Name;
        public int Year;
        public Genre Genre;
        public long Views;
        public long Likes;

        public double GetRating()
        {
            if (Views == 0) return 0;
            return Math.Sqrt(Math.Pow(Likes, 2) / Views);
        }

        public override string ToString()
        {
            string id = Id.ToString().PadLeft(4);
            string name = Name.PadRight(15);
            string year = ("(" + Year + ")").PadRight(8);
            string genre = Genre.ToString().PadRight(12);
            string rating = GetRating()
                .ToString("F3", CultureInfo.InvariantCulture)
                .PadLeft(8);    
            return id + name + year + genre + rating;
        }
    }

    public static class Lab3
    {
        public static void Main3()
        {
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
