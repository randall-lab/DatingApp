namespace DatingApp.Domain
{
    public class Profile
    {
        public int ProfileId { get; set; }

        // FK to Identity User (string because Identity uses string keys)
        public string? UserId { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public int? Age { get; set; }
        public string? Gender { get; set; }

        public string? Bio { get; set; }
        public string? Interest { get; set; }

        public string? PhotoURL { get; set; }
        public string? RegionName { get; set; }

        public bool IsVerified { get; set; }
        public DateTime LastActiveDate { get; set; }
    }
}
