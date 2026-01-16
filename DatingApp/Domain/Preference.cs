using System.ComponentModel.DataAnnotations.Schema;

namespace DatingApp.Domain
{
    public class Preference
    {
        public int PreferenceId { get; set; }

        // FK to Identity User (string because Identity uses string keys)
        public string? UserId { get; set; } = string.Empty;

        public string? PreferredGender { get; set; }
        public int MinAge { get; set; } = 18;
        public int MaxAge { get; set; } = 35;
        public int LocationRadius { get; set; } = 10;

        [NotMapped] 
        public string? UserFullName { get; set; } // admin side to see full name of users

        [NotMapped]
        public bool ShowFullId { get; set; } // easy userid access
    }
}
