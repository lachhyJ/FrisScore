namespace FrisScore.Core.Entities;

public class Tournament {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    
    public ICollection<TournamentTeam> TournamentTeams { get; set; } = new List<TournamentTeam>();
}