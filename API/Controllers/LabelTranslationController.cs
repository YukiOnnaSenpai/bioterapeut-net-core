using BioterapeutDAL.Models;
using BioterapeutDAL.Models.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/labelTranslation")]
    [ApiController]
    public class LabelTranslationController : ControllerBase
    {
        private readonly BioterapeutContext _context;

        public LabelTranslationController(BioterapeutContext context)
        {
            _context = context;
        }

        // GET: api/LabelTranslations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LabelTranslation>>> GetLabelTranslations()
        {
            return await _context.LabelTranslations.ToListAsync();
        }

        // GET: api/LabelTranslations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LabelTranslation>> GetLabelTranslation(int? id)
        {
            var labelTranslation = await _context.LabelTranslations.FindAsync(id);

            if (labelTranslation == null)
            {
                return NotFound();
            }

            return labelTranslation;
        }

        // PUT: api/LabelTranslations/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLabelTranslation(int? id, LabelTranslation labelTranslation)
        {
            if (id != labelTranslation.Id)
            {
                return BadRequest();
            }

            _context.Entry(labelTranslation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LabelTranslationExists(id))
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

        // POST: api/LabelTranslations
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<LabelTranslation>> PostLabelTranslation(LabelTranslation labelTranslation)
        {
            _context.LabelTranslations.Add(labelTranslation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLabelTranslation", new { id = labelTranslation.Id }, labelTranslation);
        }

        // DELETE: api/LabelTranslations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LabelTranslation>> DeleteLabelTranslation(int? id)
        {
            var labelTranslation = await _context.LabelTranslations.FindAsync(id);
            if (labelTranslation == null)
            {
                return NotFound();
            }

            _context.LabelTranslations.Remove(labelTranslation);
            await _context.SaveChangesAsync();

            return labelTranslation;
        }

        private bool LabelTranslationExists(int? id)
        {
            return _context.LabelTranslations.Any(e => e.Id == id);
        }
    }
}
