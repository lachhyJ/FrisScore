using FrisScore.Core.Data;
using FrisScore.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrisScore.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TeamsController : ControllerBase {
    private readonly FrisScoreDbContext _context;

    public TeamsController(FrisScoreDbContext context) {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Team>>> GetTeams() {
        return await _context.Teams.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Team>> GetTeam(int id) {
        var team = await _context.Teams.FindAsync(id);
        if (team == null) return NotFound();
        return team;
    }

    [HttpPost]
    public async Task<ActionResult<Team>> CreateTeam(Team team) {
        _context.Teams.Add(team);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetTeam), new { id = team.Id }, team);
    }
}