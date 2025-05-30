﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BropertyBrosApi.Data;
using BropertyBrosApi.Models;
using AutoMapper;
using BropertyBrosApi2._0.DTOs.Properties;
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
    public class PropertyController : ControllerBase
    {
        private readonly IPropertyRepository propertyRepository;
        private readonly IMapper _mapper;

        public PropertyController(IPropertyRepository propertyRepository, IMapper mapper)
        {
            this.propertyRepository = propertyRepository;
            _mapper = mapper;
        }

        // GET: api/Property
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PropertyReadDto>>> GetProperties()
        {
            try
            {
                var properties = await propertyRepository.GetAllAsync();
                return Ok(properties);
            }
            catch
            {
                return StatusCode(500, "An error occurred while retrieving properties.");
            }
        }

        // GET: api/Property/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PropertyReadDto>> GetProperty(int id)
        {
            try
            {
                var property = await propertyRepository.GetByIdAsync(id);

                if (property == null)
                {
                    return NotFound();
                }

                var propertyReadDto = _mapper.Map<PropertyReadDto>(property);

                return Ok(propertyReadDto);
            }
            catch
            {
                return StatusCode(500, "An error occurred while retrieving properties.");
            }
        }

        // PUT: api/Property/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = IdentityRoles.AdminAndUser)]
        public async Task<IActionResult> PutProperty(int id, PropertyCreateDto propertyCreateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var property = await propertyRepository.GetByIdAsync(id);
                if (property == null)
                {
                    return BadRequest();
                }

                _mapper.Map(propertyCreateDto, property);

                await propertyRepository.Update(property);

                return Ok(propertyCreateDto);
            }
            catch
            {
                return StatusCode(500, "An error occurred while retrieving properties.");
            }
        }

        // POST: api/Property
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = IdentityRoles.AdminAndUser)]
        public async Task<ActionResult<PropertyReadDto>> PostProperty(PropertyCreateDto propertyCreateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var property = _mapper.Map<Property>(propertyCreateDto);
                if (property == null)
                {
                    return BadRequest();
                }

                await propertyRepository.Add(property);

                var propertyReadDto = _mapper.Map<PropertyReadDto>(property);

                return Ok(propertyReadDto);
            }
            catch
            {
                return StatusCode(500, "An error occurred while retrieving properties.");
            }
        }

        // DELETE: api/Property/5
        [HttpDelete("{id}")]
        [Authorize(Roles = IdentityRoles.AdminAndUser)]
        public async Task<IActionResult> DeleteProperty(int id)
        {
            try
            {
                var property = await propertyRepository.GetByIdAsync(id);
                if (property == null)
                {
                    return NotFound();
                }

                await propertyRepository.Delete(@property);

                return NoContent();
            }
            catch
            {
                return StatusCode(500, "An error occurred while retrieving properties.");
            }
        }


        // Author: Emil
        [HttpGet]
        [Route("GetPropertiesByRealtor/{realtorId}")]
        public async Task<ActionResult<IEnumerable<PropertyReadDto>>> GetPropertiesByRealtor(int realtorId)
        {
            try
            {
                var properties = await propertyRepository.GetAllByRealtorAsync(realtorId);
                var propertyReadDtos = new List<PropertyReadDto>();
                _mapper.Map(properties, propertyReadDtos);
                return Ok(propertyReadDtos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("GetPropertiesBySearch/")]
        public async Task<ActionResult<IEnumerable<PropertyReadDto>>> GetPropertiesBySearch([FromBody] PropertySearchDto propertySearchDto)
        {
            var properties = await propertyRepository.GetBySearchAsync(propertySearchDto);

            if (properties == null)
            {
                return NotFound();
            }

            var propertyReadDtos = new List<PropertyReadDto>();
            _mapper.Map(properties, propertyReadDtos);

            return Ok(propertyReadDtos);
        }
    }
}
