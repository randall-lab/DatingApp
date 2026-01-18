using System.ComponentModel.DataAnnotations.Schema;

namespace DatingApp.Domain
{
    public class Swipe
    {
        public int SwipeId { get; set; }

        public string? UserId_From { get; set; } = string.Empty;
        public string? UserId_To { get; set; } = string.Empty;
        public bool IsLiked { get; set; } // true = like, false = pass
        public DateTime SwipeDate { get; set; } = DateTime.Now;

        // Extra properties for display only
        [NotMapped] 
        public string? UserFromName { get; set; } 
        [NotMapped] 
        public string? UserToName { get; set; }
    }
}
