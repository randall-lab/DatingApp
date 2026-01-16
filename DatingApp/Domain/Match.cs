using DatingApp.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatingApp.Domain
{
    public class Match
    {
        public int MatchId { get; set; }
        public DateTime MatchDate { get; set; }
        public bool Active { get; set; }

        // Two users in the match
        public string UserId_One { get; set; } = string.Empty; 
        public string UserId_Two { get; set; } = string.Empty; 

        [NotMapped]
        public string? UserOneName { get; set; } // for admin side of seeing usernames
        [NotMapped]
        public string? UserTwoName { get; set; } // for admin side of seeing usernames

        [NotMapped] 
        public string? OtherUserName { get; set; } // for user side of seeing usernames
        [NotMapped] 
        public string? OtherUserPhoto { get; set; } // for user side of seeing 
    }
}
