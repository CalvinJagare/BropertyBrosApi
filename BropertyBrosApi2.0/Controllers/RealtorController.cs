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
using BropertyBrosApi2._0.Repositories.RepInterfaces;
using BropertyBrosApi2._0.Repositories;

namespace BropertyBrosApi2._0.Controllers
{
    //Author: Calvin, Daniel
    //Co-Author: Emil, Arlind, Nayab
    [Route("api/[controller]")]
    [ApiController]
    public class RealtorController : ControllerBase
    {
        private readonly IRealtorRepository realtorRepository;
        private readonly IMapper _mapper;

        public RealtorController(IRealtorRepository realtorRepository, IMapper mapper)
        {
            this.realtorRepository = realtorRepository;
            _mapper = mapper;
        }

        // GET: api/Realtor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RealtorReadDto>>> GetRealtors()
        {
            try
            {
                var realtors = await realtorRepository.GetAllAsync();
                return Ok(realtors);
            }
            catch
            {
                return StatusCode(500, "An error occurred while retrieving realtors.");
            }
        }

        // GET: api/Realtor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RealtorReadDto>> GetRealtor(int id)
        {
            try
            {
                var realtor = await realtorRepository.GetByIdAsync(id);

                if (realtor == null)
                {
                    return NotFound();
                }

                var categoryReadDto = _mapper.Map<RealtorReadDto>(realtor);

                return Ok(categoryReadDto);
            }
            catch
            {
                return StatusCode(500, "An error occurred while retrieving the realtor.");
            }
        }

        // PUT: api/Realtor/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult> PutRealtor(int id, RealtorCreateDto realtorCreateDto)
        {
            try
            {
                var realtor = await realtorRepository.GetByIdAsync(id);
                if (realtor == null)
                {
                    return BadRequest();
                }

                _mapper.Map(realtorCreateDto, realtor);

                await realtorRepository.Update(realtor);

                return Ok(realtorCreateDto);
            }
            catch
            {
                return StatusCode(500, "An error occurred while updating the realtor.");
            }
        }

        // POST: api/Realtor
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RealtorReadDto>> PostRealtor(RealtorCreateDto realtorCreateDto)
        {
            try
            {
                var realtor = _mapper.Map<Realtor>(realtorCreateDto);
                if (realtor == null)
                {
                    return BadRequest();
                }
                await realtorRepository.Add(realtor);

                var realtorReadDto = _mapper.Map<RealtorReadDto>(realtor);

                return CreatedAtAction("GetRealtor", new { id = realtor.Id }, realtor);
            }
            catch
            {
                return StatusCode(500, "An error occurred while creating the realtor.");
            }
        }

        // DELETE: api/Realtor/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRealtor(int id)
        {
            try
            {
                var realtor = await realtorRepository.GetByIdAsync(id);
                if (realtor == null)
                {
                    return NotFound();
                }
                await realtorRepository.Delete(realtor);

                return NoContent();
            }
            catch
            {
                return StatusCode(500, "An error occurred while deleting the realtor.");
            }

        }

        // Author: Emil
        [HttpGet]
        [Route("GetRealtorsBySearch")]
        public async Task<ActionResult<IEnumerable<RealtorReadDto>>> GetRealtorsBySearchAsync(RealtorSearchDto realtorSearchDto)
        {
            try
            {
                var realtors = await realtorRepository.GetBySearchAsync(realtorSearchDto);

                if (realtors == null)
                {
                    return NotFound();
                }

                List<RealtorReadDto> realtorReadDtos = new();
                _mapper.Map(realtors, realtorReadDtos);

                return Ok(realtorReadDtos);
            }
            catch(Exception ex)
            {
                return StatusCode(500, "An error occured while processing your search");
            }
        }
        
        [HttpGet("GetByUserId/{userId}")]
        public async Task<ActionResult<int>> GetRealtorIdByUserId(string userId)
        {
            var realtor = await realtorRepository.GetByUserIdAsync(userId);
            if (realtor == null)
            {
                return NotFound();
            }
            return Ok(realtor.Id);
        }


    }
}
