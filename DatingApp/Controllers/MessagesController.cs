using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatingApp.Domain;
using DatingApp.Data;

namespace DatingAppAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessagesController : ControllerBase
    {
        private readonly DatingAppContext _context;

        public MessagesController(DatingAppContext context)
        {
            _context = context;
        }

        // GET: api/messages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Message>>> GetAll()
        {
            return await _context.Message.ToListAsync();
        }

        // GET: api/messages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Message>> GetById(int id)
        {
            var message = await _context.Message.FindAsync(id);
            if (message == null) return NotFound();
            return message;
        }

        // POST: api/messages
        [HttpPost]
        public async Task<ActionResult<Message>> Create(Message message)
        {
            message.Timestamp = DateTime.Now; // auto‑set timestamp
            _context.Message.Add(message);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = message.MessageId }, message);
        }

        // PUT: api/messages/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Message updatedMessage)
        {
            if (id != updatedMessage.MessageId) return BadRequest();

            _context.Entry(updatedMessage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Message.Any(m => m.MessageId == id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // DELETE: api/messages/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var message = await _context.Message.FindAsync(id);
            if (message == null) return NotFound();

            _context.Message.Remove(message);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
