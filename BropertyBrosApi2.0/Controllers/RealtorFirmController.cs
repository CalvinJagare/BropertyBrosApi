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
using BropertyBrosApi2._0.DTOs.RealtorFirm;

namespace BropertyBrosApi2._0.Controllers
{
    //Author: Calvin, Daniel
    //Co-Author: Emil, Arlind, Nayab
    [Route("api/[controller]")]
    [ApiController]
    public class RealtorFirmController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public RealtorFirmController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/RealtorFirm
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RealtorFirm>>> GetRealtorFirms()
        {
            return await _context.RealtorFirms.ToListAsync();
        }

        // GET: api/RealtorFirm/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RealtorFirmReadDto>> GetRealtorFirm(int id)
        {
            var realtorFirm = await _context.RealtorFirms.FindAsync(id);

            if (realtorFirm == null)
            {
                return NotFound();
            }

            var realtorFirmReadDto = _mapper.Map<RealtorFirm>(realtorFirm);

            return Ok(realtorFirmReadDto);
        }

        // PUT: api/RealtorFirm/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRealtorFirm(int id, RealtorFirmCreateDto realtorFirmCreateDto)
        {
            var realtorFirm = await _context.RealtorFirms.FindAsync(id);
            if (realtorFirm == null)
            {
                return BadRequest();
            }

            _mapper.Map(realtorFirmCreateDto, realtorFirm);

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/RealtorFirm
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RealtorFirmReadDto>> PostRealtorFirm(RealtorFirmCreateDto realtorFirmCreateDto)
        {
            var realtorFirm = _mapper.Map<RealtorFirm>(realtorFirmCreateDto);

            _context.RealtorFirms.Add(realtorFirm);
            await _context.SaveChangesAsync();

            var realtorFirmReadDto = _mapper.Map<RealtorFirmReadDto>(realtorFirm);

            return CreatedAtAction("GetRealtorFirm", new { id = realtorFirm.Id }, realtorFirmReadDto);
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
