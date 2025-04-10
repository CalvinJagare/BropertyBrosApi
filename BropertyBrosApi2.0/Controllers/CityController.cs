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
using BropertyBrosApi2._0.Repositories.RepInterfaces;
using BropertyBrosApi2._0.Repositories;

namespace BropertyBrosApi2._0.Controllers
{
    //Author: Alla
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityRepository cityRepository;
        private readonly IMapper _mapper;

        public CityController(ICityRepository cityRepository, IMapper mapper)
        {
            this.cityRepository = cityRepository;
            _mapper = mapper;
        }

        // GET: api/Citiy
        [HttpGet]
        public async Task<ActionResult<IEnumerable<City>>> GetCities()
        {
            var cities = await cityRepository.GetAllAsync();
            return Ok(cities);
        }

        // GET: api/Citiy/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CityReadDto>> GetCity(int id)
        {
            var city = await cityRepository.GetByIdAsync(id);

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
            var city = await cityRepository.GetByIdAsync(id);
            if (city == null)
            {
                return BadRequest();
            }

            _mapper.Map(cityCreateDto, city);

            await cityRepository.Update(city);

            return NoContent();
        }

        // POST: api/Citiy
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CityReadDto>> PostCity(CityCreateDto cityCreateDto)
        {
            var city = _mapper.Map<City>(cityCreateDto);
            if (city == null)
            {
                return BadRequest();
            }
            await cityRepository.Add(city);

            var cityReadDto = _mapper.Map<CityReadDto>(city);

            return CreatedAtAction("GetCity", new { id = city.Id }, cityReadDto);
        }

        // DELETE: api/Citiy/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCity(int id)
        {
            var city = await cityRepository.GetByIdAsync(id);
            if (city == null)
            {
                return NotFound();
            }

            await cityRepository.Delete(city);

            return NoContent();
        }
    }
}
