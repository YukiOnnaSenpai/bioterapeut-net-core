using API.Dao;
using API.Services;
using API.Services.Implementations;
using BioterapeutDAL.Models.Classes;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/label")]
    [ApiController]
    public class LabelController : ControllerBase
    {
        private readonly IService<LabelDao> _service;

        public LabelController(IService<LabelDao> service)
        {
            _service = service;
        }

        // GET: api/Labels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LabelDao>>> GetLabel()
        {
            return _service.GetAll();
        }

        // GET: api/Labels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LabelDao>> GetLabel(int id)
        {
            var label = _service.GetById(id);

            if (label == null)
            {
                return NotFound();
            }

            return label;
        }

        // PUT: api/Labels/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLabel(int? id, LabelDao label)
        {
            if (id != label.Id)
            {
                return BadRequest();
            }

            _service.Update(label);

            return Ok();
        }

        // POST: api/Labels
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Label>> PostLabel(LabelDao label)
        {
            _service.Add(label);

            return CreatedAtAction("GetLabel", new { id = label.Id }, label);
        }

        // DELETE: api/Labels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Label>> DeleteLabel(int id)
        {
            _service.Delete(id);
            return Ok();
        }

        private bool LabelExists(int id)
        {
            if (_service.GetById(id) != null)
            {
                return true;
            }
            return false;
        }
    }
}
