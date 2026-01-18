using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatingApp.Domain;
using DatingApp.Data;

namespace DatingAppAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MatchesController : ControllerBase
    {
        private readonly DatingAppContext _context;

        public MatchesController(DatingAppContext context)
        {
            _context = context;
        }

        // GET: api/matches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Match>>> GetAll()
        {
            return await _context.Match.ToListAsync();
        }

        // GET: api/matches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Match>> GetById(int id)
        {
            var match = await _context.Match.FindAsync(id);
            if (match == null) return NotFound();
            return match;
        }

        // POST: api/matches
        [HttpPost]
        public async Task<ActionResult<Match>> Create(Match match)
        {
            match.MatchDate = DateTime.Now; // auto‑set match date
            match.Active = true;               // default to active when created

            _context.Match.Add(match);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = match.MatchId }, match);
        }

        // PUT: api/matches/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Match updatedMatch)
        {
            if (id != updatedMatch.MatchId) return BadRequest();

            _context.Entry(updatedMatch).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Match.Any(m => m.MatchId == id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // DELETE: api/matches/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var match = await _context.Match.FindAsync(id);
            if (match == null) return NotFound();

            _context.Match.Remove(match);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
