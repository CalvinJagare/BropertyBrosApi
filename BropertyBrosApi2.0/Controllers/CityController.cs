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
using BropertyBrosApi2._0.DTOs.City;

namespace BropertyBrosApi2._0.Controllers
{
    //Author: Calvin, Daniel
    //Co-Author: Emil, Arlind, Nayab
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CityController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Citiy
        [HttpGet]
        public async Task<ActionResult<IEnumerable<City>>> GetCities()
        {
            return await _context.Cities.ToListAsync();
        }

        // GET: api/Citiy/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CityReadDto>> GetCity(int id)
        {
            var city = await _context.Cities.FindAsync(id);

            if (city == null)
            {
                return NotFound();
            }

            var cityReadDto = _mapper.Map<CityReadDto>(city);

            return Ok(cityReadDto);
        }

        // PUT: api/Citiy/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCity(int id, CityCreateDto cityCreateDto)
        {
            var category = await _context.Cities.FindAsync(id);
            if (category == null)
            {
                return BadRequest();
            }

            _mapper.Map(cityCreateDto, category);

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/Citiy
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CityReadDto>> PostCity(CityCreateDto cityCreateDto)
        {
            var city = _mapper.Map<City>(cityCreateDto);

            _context.Cities.Add(city);
            await _context.SaveChangesAsync();

            var cityReadDto = _mapper.Map<CityReadDto>(city);

            return CreatedAtAction("GetCity", new { id = city.Id }, cityReadDto);
        }

        // DELETE: api/Citiy/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCity(int id)
        {
            var city = await _context.Cities.FindAsync(id);
            if (city == null)
            {
                return NotFound();
            }

            _context.Cities.Remove(city);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CityExists(int id)
        {
            return _context.Cities.Any(e => e.Id == id);
        }
    }
}
