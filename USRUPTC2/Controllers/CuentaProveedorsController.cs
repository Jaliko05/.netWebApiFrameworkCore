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
    public class CuentaProveedorsController : ControllerBase
    {
        private readonly DataContext _context;

        public CuentaProveedorsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/CuentaProveedors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CuentaProveedor>>> GetCuentaProveedors()
        {
            return await _context.CuentaProveedors.ToListAsync();
        }

        // GET: api/CuentaProveedors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CuentaProveedor>> GetCuentaProveedor(int id)
        {
            var cuentaProveedor = await _context.CuentaProveedors.FindAsync(id);

            if (cuentaProveedor == null)
            {
                return NotFound();
            }

            return cuentaProveedor;
        }

        // PUT: api/CuentaProveedors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCuentaProveedor(int id, CuentaProveedor cuentaProveedor)
        {
            if (id != cuentaProveedor.Id)
            {
                return BadRequest();
            }

            _context.Entry(cuentaProveedor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CuentaProveedorExists(id))
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

        // POST: api/CuentaProveedors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CuentaProveedor>> PostCuentaProveedor(CuentaProveedor cuentaProveedor)
        {
            _context.CuentaProveedors.Add(cuentaProveedor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCuentaProveedor", new { id = cuentaProveedor.Id }, cuentaProveedor);
        }

        // DELETE: api/CuentaProveedors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCuentaProveedor(int id)
        {
            var cuentaProveedor = await _context.CuentaProveedors.FindAsync(id);
            if (cuentaProveedor == null)
            {
                return NotFound();
            }

            _context.CuentaProveedors.Remove(cuentaProveedor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CuentaProveedorExists(int id)
        {
            return _context.CuentaProveedors.Any(e => e.Id == id);
        }
    }
}
