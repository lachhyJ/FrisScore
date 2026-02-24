namespace FrisScore.Core.Entities;

public class Attendance {
    public int Id { get; set; }
    public int EventId { get; set; }
    public int UserId { get; set; }
    public AttendanceStatus Status { get; set; }
    public bool MarkedByUser { get; set; }
    public bool MarkedByCoach { get; set; }
    
    public Event Event { get; set; } = null!;
    public User User { get; set; } = null!;
}