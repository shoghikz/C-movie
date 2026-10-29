using System;
using System.Globalization;

namespace Lab3
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
            return id + " " + name + year + genre + rating;
        }
    }
}