using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackendApi.Data;
using BackendApi.Models;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaticContentsController : ControllerBase
    {
        private readonly BackendApiContext _context;

        public StaticContentsController(BackendApiContext context)
        {
            _context = context;
        }

        // GET: api/StaticContents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StaticContent>>> GetStaticContent()
        {
            return await _context.StaticContent.ToListAsync();
        }

        // GET: api/StaticContents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StaticContent>> GetStaticContent(int id)
        {
            var staticContent = await _context.StaticContent.FindAsync(id);

            if (staticContent == null)
            {
                return NotFound();
            }

            return staticContent;
        }

        // PUT: api/StaticContents/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStaticContent(int id, StaticContent staticContent)
        {
            if (id != staticContent.ContentID)
            {
                return BadRequest();
            }

            _context.Entry(staticContent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StaticContentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/StaticContents
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StaticContent>> PostStaticContent(StaticContent staticContent)
        {
            _context.StaticContent.Add(staticContent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStaticContent", new { id = staticContent.ContentID }, staticContent);
        }

        // DELETE: api/StaticContents/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStaticContent(int id)
        {
            var staticContent = await _context.StaticContent.FindAsync(id);
            if (staticContent == null)
            {
                return NotFound();
            }

            _context.StaticContent.Remove(staticContent);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StaticContentExists(int id)
        {
            return _context.StaticContent.Any(e => e.ContentID == id);
        }
    }
}
