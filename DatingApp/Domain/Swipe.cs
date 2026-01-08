namespace DatingApp.Domain
{
    public class Swipe
    {
        public int SwipeId { get; set; }

        public string? UserId_From { get; set; } = string.Empty;
        public string? UserId_To { get; set; } = string.Empty;

        public bool IsLiked { get; set; }
        public bool IsDisliked { get; set; }

        public DateTime SwipeDate { get; set; } = DateTime.UtcNow;
    }
}
