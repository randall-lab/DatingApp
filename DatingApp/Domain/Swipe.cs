namespace DatingApp.Domain
{
    public class Swipe
    {
        public int SwipeId { get; set; }

        public string? UserId_From { get; set; }
        public string? UserId_To { get; set; }

        public string? Action { get; set; } // Like / Pass
    }
}
