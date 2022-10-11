using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StillsApp;

namespace StillsApp.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistilleriesController : ControllerBase
    {
        private readonly DataContext _context;

        public DistilleriesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Distilleries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Distillery>>> GetDistilleries()
        {
            return await _context.Distilleries.ToListAsync();
        }

        // GET: api/Distilleries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Distillery>> GetDistillery(int id)
        {
            var distillery = await _context.Distilleries.FindAsync(id);

            if (distillery == null)
            {
                return NotFound();
            }

            return distillery;
        }

        // PUT: api/Distilleries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDistillery(int id, Distillery distillery)
        {
            if (id != distillery.Id)
            {
                return BadRequest();
            }

            _context.Entry(distillery).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DistilleryExists(id))
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

        // POST: api/Distilleries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Distillery>> PostDistillery(Distillery distillery)
        {
            _context.Distilleries.Add(distillery);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDistillery", new { id = distillery.Id }, distillery);
        }

        // DELETE: api/Distilleries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDistillery(int id)
        {
            var distillery = await _context.Distilleries.FindAsync(id);
            if (distillery == null)
            {
                return NotFound();
            }

            _context.Distilleries.Remove(distillery);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DistilleryExists(int id)
        {
            return _context.Distilleries.Any(e => e.Id == id);
        }
    }
}
