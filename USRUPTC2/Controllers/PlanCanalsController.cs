using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using USRUPTC1.Models;
using USRUPTC2.Data;

namespace USRUPTC2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanCanalsController : ControllerBase
    {
        private readonly DataContext _context;

        public PlanCanalsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/PlanCanals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlanCanal>>> GetPlanCanals()
        {
            return await _context.PlanCanals.ToListAsync();
        }

        // GET: api/PlanCanals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PlanCanal>> GetPlanCanal(int id)
        {
            var planCanal = await _context.PlanCanals.FindAsync(id);

            if (planCanal == null)
            {
                return NotFound();
            }

            return planCanal;
        }

        // PUT: api/PlanCanals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlanCanal(int id, PlanCanal planCanal)
        {
            if (id != planCanal.Id)
            {
                return BadRequest();
            }

            _context.Entry(planCanal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlanCanalExists(id))
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

        // POST: api/PlanCanals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PlanCanal>> PostPlanCanal(PlanCanal planCanal)
        {
            _context.PlanCanals.Add(planCanal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlanCanal", new { id = planCanal.Id }, planCanal);
        }

        // DELETE: api/PlanCanals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlanCanal(int id)
        {
            var planCanal = await _context.PlanCanals.FindAsync(id);
            if (planCanal == null)
            {
                return NotFound();
            }

            _context.PlanCanals.Remove(planCanal);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlanCanalExists(int id)
        {
            return _context.PlanCanals.Any(e => e.Id == id);
        }
    }
}
