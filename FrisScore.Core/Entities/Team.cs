namespace FrisScore.Core.Entities;

public class Team {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    
    public ICollection<UserTeam> UserTeams { get; set; } = new List<UserTeam>();
    public ICollection<Event> Events { get; set; } = new List<Event>();
    public ICollection<TournamentTeam> TournamentTeams { get; set; } = new List<TournamentTeam>();
}