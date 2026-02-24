using FrisScore.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace FrisScore.Core.Data;

public class FrisScoreDbContext : DbContext {
    public FrisScoreDbContext(DbContextOptions<FrisScoreDbContext> options) : base(options) { }

    public DbSet<Team> Teams { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserTeam> UserTeams { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Training> Trainings { get; set; }
    public DbSet<Game> Games { get; set; }
    public DbSet<Attendance> Attendances { get; set; }
    public DbSet<Tournament> Tournaments { get; set; }
    public DbSet<TournamentTeam> TournamentTeams { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<UserTeam>()
            .HasIndex(ut => new { ut.UserId, ut.TeamId, ut.StartDate })
            .IsUnique();

        modelBuilder.Entity<Attendance>()
            .HasIndex(a => new { a.EventId, a.UserId })
            .IsUnique();

        modelBuilder.Entity<TournamentTeam>()
            .HasIndex(tt => new { tt.TournamentId, tt.TeamId })
            .IsUnique();

        modelBuilder.Entity<Training>()
            .HasKey(t => t.EventId);

        modelBuilder.Entity<Game>()
            .HasKey(g => g.EventId);
    }
}