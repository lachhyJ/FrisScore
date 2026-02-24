namespace FrisScore.Core.Entities;

public class UserTeam {
    public int Id { get; set; }
    public int UserId { get; set; }
    public int TeamId { get; set; }
    public UserRole Role { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly? EndDate { get; set; }
    
    public User User { get; set; } = null!;
    public Team Team { get; set; } = null!;
}