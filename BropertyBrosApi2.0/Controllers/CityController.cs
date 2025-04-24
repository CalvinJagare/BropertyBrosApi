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
using Microsoft.AspNetCore.Authorization;
using BropertyBrosApi2._0.Constants;

namespace BropertyBrosApi2._0.Controllers
{
    //Author: Calvin, Daniel
    //Co-Author: Emil, Arlind, Nayab
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
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
            try
            {
                var cities = await cityRepository.GetAllAsync();
                return Ok(cities);
            }
            catch
            {
                return StatusCode(500, "An error occurred while retrieving cities.");
            }
        }


        // GET: api/Citiy/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CityReadDto>> GetCity(int id)
        {
            try
            {
                var city = await cityRepository.GetByIdAsync(id);

                if (city == null)
                {
                    return NotFound();
                }

                var cityReadDto = _mapper.Map<CityReadDto>(city);

                return Ok(cityReadDto);
            }
            catch
            {
                return StatusCode(500, "An error occurred while retrieving the city.");
            }
        }

        // PUT: api/Citiy/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = ApiRoles.Admin)]
        public async Task<IActionResult> PutCity(int id, CityCreateDto cityCreateDto)
        {
            try
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
            catch
            {
                return StatusCode(500, "An error occurred while updating the city.");
            }
        }

        // POST: api/Citiy
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CityReadDto>> PostCity(CityCreateDto cityCreateDto)
        {
            try
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
            catch
            {
                return StatusCode(500, "An error occurred while creating the city.");
            }
        }

        // DELETE: api/Citiy/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCity(int id)
        {
            try
            {
                var city = await cityRepository.GetByIdAsync(id);
                if (city == null)
                {
                    return NotFound();
                }

                await cityRepository.Delete(city);

                return NoContent();
            }
            catch
            {
                return StatusCode(500, "An error occurred while deleting the city.");
            }
        }
    }
}
