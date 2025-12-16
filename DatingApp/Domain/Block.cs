namespace DatingApp.Domain
{
    public class Block
    {
        public int BlockId { get; set; }

        public string? BlockerId { get; set; }
        public string? BlockedUserId { get; set; }

        public DateTime BlockedDate { get; set; }
    }
}
