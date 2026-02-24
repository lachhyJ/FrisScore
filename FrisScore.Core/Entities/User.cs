namespace FrisScore.Core.Entities;

public class User {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    
    public ICollection<UserTeam> UserTeams { get; set; } = new List<UserTeam>();
    public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
}