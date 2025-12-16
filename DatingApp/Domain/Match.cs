namespace DatingApp.Domain
{
    public class Match
    {
        public int MatchId { get; set; }

        public DateTime MatchDate { get; set; }
        public bool Active { get; set; }
    }
}
