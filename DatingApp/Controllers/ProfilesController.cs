using DatingApp.Data;
using DatingApp.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingAppAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfilesController : ControllerBase
    {
        private readonly DatingAppContext _context;

        public ProfilesController(DatingAppContext context)
        {
            _context = context;
        }

        // GET /Profiles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Profile>>> GetAll()
        {
            return await _context.Profile.ToListAsync();
        }

        // GET /Profiles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Profile>> GetById(int id)
        {
            var profile = await _context.Profile.FindAsync(id);
            if (profile == null) return NotFound();
            return profile;
        }

        // POST /Profiles
        [HttpPost]
        public async Task<ActionResult<Profile>> Create(Profile profile)
        {
            _context.Profile.Add(profile);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = profile.ProfileId }, profile);
        }

        // PUT /Profiles/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Profile updatedProfile)
        {
            if (id != updatedProfile.ProfileId) return BadRequest();

            _context.Entry(updatedProfile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Profile.Any(p => p.ProfileId == id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // DELETE /Profiles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var profile = await _context.Profile.FindAsync(id);
            if (profile == null) return NotFound();

            _context.Profile.Remove(profile);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
