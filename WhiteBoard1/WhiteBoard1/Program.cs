namespace WhiteBoard1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Star> ratings = new List<Star>()
            {
                new Star()
                {
                    Id = 1,
                    CreatedByUserEmail = "email",
                    NumberOfStars = 4
                },
                new Star()
                {
                    Id = 2,
                    CreatedByUserEmail = "email",
                    NumberOfStars = 5
                },
                new Star()
                {
                    Id = 3,
                    CreatedByUserEmail = "email",
                    NumberOfStars = 4
                },
                new Star()
                {
                    Id = 4,
                    CreatedByUserEmail = "email",
                    NumberOfStars = 5
                },
                new Star()
                {
                    Id = 5,
                    CreatedByUserEmail = "email",
                    NumberOfStars = 4
                },
                new Star()
                {
                    Id = 6,
                    CreatedByUserEmail = "email",
                    NumberOfStars = 3
                },
                new Star()
                {
                    Id = 7,
                    CreatedByUserEmail = "email",
                    NumberOfStars = 0
                },
                new Star()
                {
                    Id = 8,
                    CreatedByUserEmail = "email",
                    NumberOfStars = 1
                },
                new Star()
                {
                    Id = 9,
                    CreatedByUserEmail = "email",
                    NumberOfStars = 4
                },
                new Star()
                {
                    Id = 10,
                    CreatedByUserEmail = "email",
                    NumberOfStars = 5
                },
            };
            Console.WriteLine(CalculateAverageRating(ratings));
        }
        static double CalculateAverageRating(List<Star> ratings)
        {
            int numberOfRatings = ratings.Count;
            int totalRating = ratings.Sum(r => r.NumberOfStars);
            double averageRating = 1.0 * totalRating / numberOfRatings;

            return Math.Round(averageRating * 2) / 2.0;
        }
    }
    public class Star
    {
        public int Id { get; set; }
        public string CreatedByUserEmail { get; set; }
        public int NumberOfStars { get; set; }
    }
}
