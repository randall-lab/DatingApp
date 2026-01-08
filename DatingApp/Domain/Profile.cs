namespace DatingApp.Domain
{
    public class Profile
    {
        // Primary Key
        public int ProfileId { get; set; }

        // Foreign Key to AspNetUsers
        public string UserId { get; set; } = string.Empty;

        // Optional fields
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public string? Gender { get; set; }
        public string? RegionName { get; set; }
        public string? Bio { get; set; }
        public string? Interest { get; set; }
        public string? PhotoURL { get; set; }

        // System-controlled fields
        public bool IsVerified { get; set; }
        public DateTime LastActiveDate { get; set; }
    }
}
