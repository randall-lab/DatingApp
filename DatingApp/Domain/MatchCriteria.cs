namespace DatingApp.Domain
{
    public class MatchCriteria
    {
        public int MatchCriteriaId { get; set; }
        public int MatchId { get; set; }
        public int PreferenceId { get; set; } // FK to Preference
        public int ProfileId { get; set; } // FK to Profile
        public string CriteriaType { get; set; } = string.Empty; // "Age", "Gender", "Location"
        public string CriteriaValue { get; set; } = string.Empty; // e.g. "25-30", "Female", "Jurong East"
    }
}
