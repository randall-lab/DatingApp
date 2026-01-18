using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatingApp.Domain;
using DatingApp.Data;

namespace DatingAppAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SwipesController : ControllerBase
    {
        private readonly DatingAppContext _context;

        public SwipesController(DatingAppContext context)
        {
            _context = context;
        }

        // GET: api/swipes
        // Optional: useful for debugging, not needed in production
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Swipe>>> GetAll()
        {
            return await _context.Swipe.ToListAsync();
        }

        // GET: api/swipes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Swipe>> GetById(int id)
        {
            var swipe = await _context.Swipe.FindAsync(id);
            if (swipe == null) return NotFound();
            return swipe;
        }

        // POST: api/swipes
        // Main endpoint: record a swipe action
        [HttpPost]
        public async Task<ActionResult<Swipe>> Create(Swipe swipe)
        {
            swipe.SwipeDate = DateTime.Now; // auto‑set timestamp
            _context.Swipe.Add(swipe);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = swipe.SwipeId }, swipe);
        }

        // DELETE: api/swipes/5
        // Optional: remove a swipe (not common in production)
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var swipe = await _context.Swipe.FindAsync(id);
            if (swipe == null) return NotFound();

            _context.Swipe.Remove(swipe);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
