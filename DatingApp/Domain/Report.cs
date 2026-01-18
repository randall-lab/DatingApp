namespace DatingApp.Domain
{
    public class Report
    {
        public int ReportId { get; set; }
        public string? ReporterId { get; set; }
        public string? ReportedUserId { get; set; }
        public string? Reason { get; set; }
        public DateTime ReportedDate { get; set; }
        public string? Status { get; set; }
    }
}
