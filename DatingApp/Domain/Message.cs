namespace DatingApp.Domain
{
    public class Message
    {
        public int MessageId { get; set; }

        public int MatchId { get; set; } // FK to Match
        public string? SenderId { get; set; }
        public string? ReceiverId { get; set; }

        public string? MessageText { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
