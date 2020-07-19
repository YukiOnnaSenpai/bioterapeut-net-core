using BioterapeutDAL.Models;
using BioterapeutDAL.Models.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/merchendise")]
    [ApiController]
    public class MerchendiseController : ControllerBase
    {
        private readonly BioterapeutContext _context;

        public MerchendiseController(BioterapeutContext context)
        {
            _context = context;
        }

        // GET: api/Merchendises
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Merchendise>>> GetMerchendise()
        {
            return await _context.Merchendise.ToListAsync();
        }

        // GET: api/Merchendises/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Merchendise>> GetMerchendise(int? id)
        {
            var merchendise = await _context.Merchendise.FindAsync(id);

            if (merchendise == null)
            {
                return NotFound();
            }

            return merchendise;
        }

        // PUT: api/Merchendises/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMerchendise(int? id, Merchendise merchendise)
        {
            if (id != merchendise.Id)
            {
                return BadRequest();
            }

            _context.Entry(merchendise).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MerchendiseExists(id))
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

        // POST: api/Merchendises
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Merchendise>> PostMerchendise(Merchendise merchendise)
        {
            _context.Merchendise.Add(merchendise);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMerchendise", new { id = merchendise.Id }, merchendise);
        }

        // DELETE: api/Merchendises/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Merchendise>> DeleteMerchendise(int? id)
        {
            var merchendise = await _context.Merchendise.FindAsync(id);
            if (merchendise == null)
            {
                return NotFound();
            }

            _context.Merchendise.Remove(merchendise);
            await _context.SaveChangesAsync();

            return merchendise;
        }

        private bool MerchendiseExists(int? id)
        {
            return _context.Merchendise.Any(e => e.Id == id);
        }
    }
}
