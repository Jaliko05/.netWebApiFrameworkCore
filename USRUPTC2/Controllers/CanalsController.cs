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
    public class CanalsController : ControllerBase
    {
        private readonly DataContext _context;

        public CanalsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Canals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Canal>>> GetCanals()
        {
            return await _context.Canals.ToListAsync();
        }

        // GET: api/Canals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Canal>> GetCanal(int id)
        {
            var canal = await _context.Canals.FindAsync(id);

            if (canal == null)
            {
                return NotFound();
            }

            return canal;
        }

        // PUT: api/Canals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCanal(int id, Canal canal)
        {
            if (id != canal.CodigoCanal)
            {
                return BadRequest();
            }

            _context.Entry(canal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CanalExists(id))
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

        // POST: api/Canals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Canal>> PostCanal(Canal canal)
        {
            _context.Canals.Add(canal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCanal", new { id = canal.CodigoCanal }, canal);
        }

        // DELETE: api/Canals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCanal(int id)
        {
            var canal = await _context.Canals.FindAsync(id);
            if (canal == null)
            {
                return NotFound();
            }

            _context.Canals.Remove(canal);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CanalExists(int id)
        {
            return _context.Canals.Any(e => e.CodigoCanal == id);
        }
    }
}
