namespace DatingApp.Domain
{
    public class MatchParticipant
    {
        public int MatchParticipantId { get; set; }

        public int MatchId { get; set; }
        public string? UserId { get; set; }
    }
}
