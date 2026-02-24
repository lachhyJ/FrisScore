namespace FrisScore.Core.Entities;

public class Game {
    public int EventId { get; set; }
    public int TournamentTeamId { get; set; }
    public string Opponent { get; set; } = string.Empty;
    public int? TimeCap { get; set; }
    public int? ScoreCap { get; set; }
    
    public Event Event { get; set; } = null!;
    public TournamentTeam TournamentTeam { get; set; } = null!;
}