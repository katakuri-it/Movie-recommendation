namespace Movie_recommendation.Entities
{
    public class GenresMovies
    {
        public int Id { get; set; }
        public int MoviesID { get; set; }
        public Movies Movies { get; set; }
        public int GenresID { get; set; }
        public Genres Genres { get; set; }
    }
}
