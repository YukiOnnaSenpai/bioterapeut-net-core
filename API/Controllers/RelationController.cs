using BioterapeutDAL.Models;
using BioterapeutDAL.Models.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/relation")]
    [ApiController]
    public class RelationController : ControllerBase
    {
        private readonly BioterapeutContext _context;

        public RelationController(BioterapeutContext context)
        {
            _context = context;
        }

        // GET: api/RelationUserAppointments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RelationUserAppointment>>> GetRelationUserAppointment()
        {
            return await _context.RelationUserAppointment.ToListAsync();
        }

        // GET: api/RelationUserAppointments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RelationUserAppointment>> GetRelationUserAppointment(int? id)
        {
            var relationUserAppointment = await _context.RelationUserAppointment.FindAsync(id);

            if (relationUserAppointment == null)
            {
                return NotFound();
            }

            return relationUserAppointment;
        }

        // PUT: api/RelationUserAppointments/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRelationUserAppointment(int? id, RelationUserAppointment relationUserAppointment)
        {
            if (id != relationUserAppointment.Id)
            {
                return BadRequest();
            }

            _context.Entry(relationUserAppointment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RelationUserAppointmentExists(id))
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

        // POST: api/RelationUserAppointments
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<RelationUserAppointment>> PostRelationUserAppointment(RelationUserAppointment relationUserAppointment)
        {
            _context.RelationUserAppointment.Add(relationUserAppointment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRelationUserAppointment", new { id = relationUserAppointment.Id }, relationUserAppointment);
        }

        // DELETE: api/RelationUserAppointments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RelationUserAppointment>> DeleteRelationUserAppointment(int? id)
        {
            var relationUserAppointment = await _context.RelationUserAppointment.FindAsync(id);
            if (relationUserAppointment == null)
            {
                return NotFound();
            }

            _context.RelationUserAppointment.Remove(relationUserAppointment);
            await _context.SaveChangesAsync();

            return relationUserAppointment;
        }

        private bool RelationUserAppointmentExists(int? id)
        {
            return _context.RelationUserAppointment.Any(e => e.Id == id);
        }
    }
}
