using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrustPower_Item_Booking_Web_App.Models;

namespace TrustPower_Item_Booking_Web_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepotsController : ControllerBase
    {
        private readonly BookingDBContext _context;

        public DepotsController(BookingDBContext context)
        {
            _context = context;
        }

        // GET: api/Depots
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Depots>>> GetDepots()
        {
            return await _context.Depots.ToListAsync();
        }

        // GET: api/Depots/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Depots>> GetDepots(int id)
        {
            var depots = await _context.Depots.FindAsync(id);

            if (depots == null)
            {
                return NotFound();
            }

            return depots;
        }

        // PUT: api/Depots/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepots(int id, Depots depots)
        {
            if (id != depots.DepotId)
            {
                return BadRequest();
            }

            _context.Entry(depots).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepotsExists(id))
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

        // POST: api/Depots
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Depots>> PostDepots(Depots depots)
        {
            _context.Depots.Add(depots);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDepots", new { id = depots.DepotId }, depots);
        }

        // DELETE: api/Depots/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Depots>> DeleteDepots(int id)
        {
            var depots = await _context.Depots.FindAsync(id);
            if (depots == null)
            {
                return NotFound();
            }

            _context.Depots.Remove(depots);
            await _context.SaveChangesAsync();

            return depots;
        }

        private bool DepotsExists(int id)
        {
            return _context.Depots.Any(e => e.DepotId == id);
        }
    }
}
