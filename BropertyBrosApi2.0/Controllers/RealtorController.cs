using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BropertyBrosApi.Data;
using BropertyBrosApi.Models;
using AutoMapper;
using BropertyBrosApi2._0.DTOs.Realtor;

namespace BropertyBrosApi2._0.Controllers
{
    //Author: Alla
    [Route("api/[controller]")]
    [ApiController]
    public class RealtorController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;   

        public RealtorController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Realtor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Realtor>>> GetRealtors()
        {
            return await _context.Realtors.ToListAsync();
        }

        // GET: api/Realtor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RealtorReadDto>> GetRealtor(int id)
        {
            var realtor = await _context.Realtors.FindAsync(id);

            if (realtor == null)
            {
                return NotFound();
            }

            var categoryReadDto = _mapper.Map<RealtorReadDto>(realtor);

            return Ok(categoryReadDto);
        }

        // PUT: api/Realtor/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRealtor(int id, RealtorCreateDto realtorCreateDto)
        {
            var realtor = await _context.Realtors.FindAsync(id);
            if (realtor == null)
            {
                return BadRequest();
            }

            _mapper.Map(realtorCreateDto, realtor);

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/Realtor
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RealtorReadDto>> PostRealtor(RealtorCreateDto realtorCreateDto)
        {
            var realtor = _mapper.Map<Realtor>(realtorCreateDto);

            _context.Realtors.Add(realtor);
            await _context.SaveChangesAsync();

            var realtorReadDto = _mapper.Map<RealtorReadDto>(realtor);

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
