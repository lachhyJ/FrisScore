namespace FrisScore.Core.Entities;

public class Training {
    public int EventId { get; set; }
    public string? Plan { get; set; }
    
    public Event Event { get; set; } = null!;
}