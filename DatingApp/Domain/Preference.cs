namespace DatingApp.Domain
{
    public class Preference
    {
        public int PreferenceId { get; set; }

        // FK to Identity User (string because Identity uses string keys)
        public string? UserId { get; set; }

        public string? PreferredGender { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public int LocationRadius { get; set; }
    }
}
