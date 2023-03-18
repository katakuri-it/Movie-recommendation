namespace Movie_recommendation.Entities
{
    public class RatingsUsers
    {
        public int Id { get; set; }
        public int RatindsID { get; set; }
        public Ratings Ratings { get; set; }
        public int UsersID { get; set; }
        public Users Users { get; set; }
    }
}
