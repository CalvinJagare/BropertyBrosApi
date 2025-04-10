using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BropertyBrosApi.Data;
using BropertyBrosApi.Models;

namespace BropertyBrosApi2._0.Controllers
{
    //Author: Alla
    [Route("api/[controller]")]
    [ApiController]
    public class RealtorController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public RealtorController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Realtor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Realtor>>> GetRealtors()
        {
            return await _context.Realtors.ToListAsync();
        }

        // GET: api/Realtor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Realtor>> GetRealtor(int id)
        {
            var realtor = await _context.Realtors.FindAsync(id);

            if (realtor == null)
            {
                return NotFound();
            }

            return realtor;
        }

        // PUT: api/Realtor/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRealtor(int id, Realtor realtor)
        {
            if (id != realtor.Id)
            {
                return BadRequest();
            }

            _context.Entry(realtor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RealtorExists(id))
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

        // POST: api/Realtor
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Realtor>> PostRealtor(Realtor realtor)
        {
            _context.Realtors.Add(realtor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRealtor", new { id = realtor.Id }, realtor);
        }

        // DELETE: api/Realtor/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRealtor(int id)
        {
            var realtor = await _context.Realtors.FindAsync(id);
            if (realtor == null)
            {
                return NotFound();
            }

            _context.Realtors.Remove(realtor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RealtorExists(int id)
        {
            return _context.Realtors.Any(e => e.Id == id);
        }
    }
}
