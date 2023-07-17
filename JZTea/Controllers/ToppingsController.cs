using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JZTea.Data;
using JZTea.Models;

namespace JZTea.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToppingsController : ControllerBase
    {
        private readonly JZTeaContext _context;

        public ToppingsController(JZTeaContext context)
        {
            _context = context;
        }

        // GET: api/Toppings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Topping>>> GetTopping()
        {
          if (_context.Topping == null)
          {
              return NotFound();
          }
            return await _context.Topping.ToListAsync();
        }

        // GET: api/Toppings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Topping>> GetTopping(int? id)
        {
          if (_context.Topping == null)
          {
              return NotFound();
          }
            var topping = await _context.Topping.FindAsync(id);

            if (topping == null)
            {
                return NotFound();
            }

            return topping;
        }

        // PUT: api/Toppings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTopping(int? id, Topping topping)
        {
            if (id != topping.id)
            {
                return BadRequest();
            }

            _context.Entry(topping).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToppingExists(id))
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

        // POST: api/Toppings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Topping>> PostTopping(Topping topping)
        {
          if (_context.Topping == null)
          {
              return Problem("Entity set 'JZTeaContext.Topping'  is null.");
          }
            _context.Topping.Add(topping);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTopping", new { id = topping.id }, topping);
        }

        // DELETE: api/Toppings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTopping(int? id)
        {
            if (_context.Topping == null)
            {
                return NotFound();
            }
            var topping = await _context.Topping.FindAsync(id);
            if (topping == null)
            {
                return NotFound();
            }

            _context.Topping.Remove(topping);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ToppingExists(int? id)
        {
            return (_context.Topping?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
