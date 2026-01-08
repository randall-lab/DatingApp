namespace DatingApp.Domain
{
    public class Match
    {
        public int MatchId { get; set; }

        public DateTime MatchDate { get; set; }
        public bool Active { get; set; }
        // Two users in the match
        public string UserId_One { get; set; } = string.Empty; 
        public string UserId_Two { get; set; } = string.Empty; // Metadata
        public string? MatchedBy { get; set; } // "Swipe", "Algorithm"
        public string? MatchedOnCriteria { get; set; } // optional summary or reference
    }
}
