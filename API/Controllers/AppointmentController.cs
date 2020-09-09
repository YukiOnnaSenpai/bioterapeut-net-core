using API.Dao;
using API.Services;
using BioterapeutDAL.Models.Classes;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/appointment")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IService<AppointmentDao> _service;

        public AppointmentController(IService<AppointmentDao> service)
        {
            _service = service;
        }

        // GET: api/Appointments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppointmentDao>>> GetAppointment()
        {
            return _service.GetAll();
        }

        // GET: api/Appointments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AppointmentDao>> GetAppointment(int id)
        {
            var appointment = _service.GetById(id);

            if (appointment == null)
            {
                return NotFound();
            }

            return appointment;
        }

        // PUT: api/Appointments/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppointment(int? id, AppointmentDao appointment)
        {
            if (id != appointment.Id)
            {
                return BadRequest();
            }

            _service.Update(appointment);

            return NoContent();
        }

        // POST: api/Appointments
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<AppointmentDao>> PostAppointment(AppointmentDao appointment)
        {
            _service.Add(appointment);

            return CreatedAtAction("GetAppointment", new { id = appointment.Id }, appointment);
        }

        // DELETE: api/Appointments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Appointment>> DeleteAppointment(int id)
        {
            _service.Delete(id);
            return NoContent();
        }

        private bool AppointmentExists(int id)
        {
            if (_service.GetById(id) != null)
            {
                return true;
            }
            return false;
        }
    }
}
