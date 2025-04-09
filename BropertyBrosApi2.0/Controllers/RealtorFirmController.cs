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
    [Route("api/[controller]")]
    [ApiController]
    public class RealtorFirmController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RealtorFirmController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RealtorFirm
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RealtorFirm>>> GetRealtorFirms()
        {
            return await _context.RealtorFirms.ToListAsync();
        }

        // GET: api/RealtorFirm/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RealtorFirm>> GetRealtorFirm(int id)
        {
            var realtorFirm = await _context.RealtorFirms.FindAsync(id);

            if (realtorFirm == null)
            {
                return NotFound();
            }

            return realtorFirm;
        }

        // PUT: api/RealtorFirm/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRealtorFirm(int id, RealtorFirm realtorFirm)
        {
            if (id != realtorFirm.Id)
            {
                return BadRequest();
            }

            _context.Entry(realtorFirm).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RealtorFirmExists(id))
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

        // POST: api/RealtorFirm
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RealtorFirm>> PostRealtorFirm(RealtorFirm realtorFirm)
        {
            _context.RealtorFirms.Add(realtorFirm);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRealtorFirm", new { id = realtorFirm.Id }, realtorFirm);
        }

        // DELETE: api/RealtorFirm/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRealtorFirm(int id)
        {
            var realtorFirm = await _context.RealtorFirms.FindAsync(id);
            if (realtorFirm == null)
            {
                return NotFound();
            }

            _context.RealtorFirms.Remove(realtorFirm);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RealtorFirmExists(int id)
        {
            return _context.RealtorFirms.Any(e => e.Id == id);
        }
    }
}
