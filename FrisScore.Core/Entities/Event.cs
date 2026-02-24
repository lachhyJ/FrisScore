namespace FrisScore.Core.Entities;

public class Event {
    public int Id { get; set; }
    public int TeamId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string Title { get; set; } = string.Empty;
    public EventType Type { get; set; }
    
    public Team Team { get; set; } = null!;
    public Training? Training { get; set; }
    public Game? Game { get; set; }
    public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
}