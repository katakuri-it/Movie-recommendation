namespace Movie_recommendation.Entities
{
    public class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public int RunTime { get; set; }
        public string Country { get; set; }
        public string Plot { get; set; }
        public int RatingsID { get; set; }
        public Ratings Ratings { get; set; }
        public List<Genres> Genres { get; set; }
    }
}
