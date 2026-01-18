using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatingApp.Domain;
using DatingApp.Data;

namespace DatingAppAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlocksController : ControllerBase
    {
        private readonly DatingAppContext _context;

        public BlocksController(DatingAppContext context)
        {
            _context = context;
        }

        // GET: api/blocks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Block>>> GetAll()
        {
            return await _context.Block.ToListAsync();
        }

        // GET: api/blocks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Block>> GetById(int id)
        {
            var block = await _context.Block.FindAsync(id);
            if (block == null) return NotFound();
            return block;
        }

        // POST: api/blocks
        [HttpPost]
        public async Task<ActionResult<Block>> Create(Block block)
        {
            block.BlockedDate = DateTime.Now; // auto‑set blocked date
            _context.Block.Add(block);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = block.BlockId }, block);
        }

        // PUT: api/blocks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Block updatedBlock)
        {
            if (id != updatedBlock.BlockId) return BadRequest();

            _context.Entry(updatedBlock).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Block.Any(b => b.BlockId == id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // DELETE: api/blocks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var block = await _context.Block.FindAsync(id);
            if (block == null) return NotFound();

            _context.Block.Remove(block);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
