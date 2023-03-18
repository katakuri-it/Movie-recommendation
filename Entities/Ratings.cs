namespace Movie_recommendation.Entities
{
    public class Ratings
    {
        public int Id { get; set; }
        public List<Users> Users { get; set; }
        public int MoviesID { get; set; }
        public Movies Movies { get; set; }
        public int RatingsOfMovie { get; set; }
        public DateTime ScoreDate { get; set; }
    }
}
