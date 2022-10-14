using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StillsApp.BL;
using StillsApp.DL;

namespace StillsApp.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistilleriesController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IDistilleryService _distilleryService;

        //public DistilleriesController(IDistilleryService distilleryService);
        public DistilleriesController(DataContext context)
        {
            _context = context;
            //_distilleryService = distilleryService;
        }

        [HttpGet]
        public ActionResult GetDistilleries()
        {
            var response = _distilleryService.GetAll();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public ActionResult<Distillery> GetDistillery(int id)
        {
            var response = _distilleryService.GetById(id);
            if (response == null) 
                { 
                    return NotFound(); 
                }
            return Ok(response);
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
