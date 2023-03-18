namespace Movie_recommendation.Entities
{
    public class Genres
    {
        public int Id { get; set; }
        public string GName { get; set; }
        public List<Movies> Movies { get; set; }
    }
}
