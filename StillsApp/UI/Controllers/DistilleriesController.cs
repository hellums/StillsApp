using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StillsApp.DL;

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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Distillery>>> GetDistilleries()
        {
            return await _context.Distilleries.ToListAsync();
        }

    [HttpGet("{id}")]
        public async Task<ActionResult<Distillery>> GetDistillery(int id)
        {
            var distillery = await _context.Distilleries
                .Include(distilleries => distilleries.Addresses)
                .Include(distilleries => distilleries.Experiences)
                .Include(distilleries => distilleries.Photos)
                .Include(distilleries => distilleries.Reviews)
                .Include(distilleries => distilleries.Brands)
                .SingleOrDefaultAsync(i => i.Id == id);

            if (distillery == null)
            {
                return NotFound();
            }

            return distillery;
        }

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

        [HttpPost]
        public async Task<ActionResult<Distillery>> PostDistillery(Distillery distillery)
        {
            _context.Distilleries.Add(distillery);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDistillery", new { id = distillery.Id }, distillery);
        }

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
