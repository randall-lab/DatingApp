using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatingApp.Domain;
using DatingApp.Data;

namespace DatingAppAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PreferencesController : ControllerBase
    {
        private readonly DatingAppContext _context;

        public PreferencesController(DatingAppContext context)
        {
            _context = context;
        }

        // GET: api/preferences
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Preference>>> GetAll()
        {
            return await _context.Preference.ToListAsync();
        }

        // GET: api/preferences/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Preference>> GetById(int id)
        {
            var preference = await _context.Preference.FindAsync(id);
            if (preference == null) return NotFound();
            return preference;
        }

        // POST: api/preferences
        [HttpPost]
        public async Task<ActionResult<Preference>> Create(Preference preference)
        {
            _context.Preference.Add(preference);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = preference.PreferenceId }, preference);
        }

        // PUT: api/preferences/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Preference updatedPreference)
        {
            if (id != updatedPreference.PreferenceId) return BadRequest();

            _context.Entry(updatedPreference).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Preference.Any(p => p.PreferenceId == id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // DELETE: api/preferences/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var preference = await _context.Preference.FindAsync(id);
            if (preference == null) return NotFound();

            _context.Preference.Remove(preference);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
