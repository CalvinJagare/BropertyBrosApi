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
using BropertyBrosApi2._0.Repositories.RepInterfaces;

namespace BropertyBrosApi2._0.Controllers
{
    //Author: Calvin, Daniel
    //Co-Author: Emil, Arlind, Nayab
    [Route("api/[controller]")]
    [ApiController]
    public class RealtorFirmController : ControllerBase
    {
        private readonly IRealtorFirmRepository realtorFirmRepository;
        private readonly IMapper _mapper;

        public RealtorFirmController(IRealtorFirmRepository realtorFirmRepository, IMapper mapper)
        {
            this.realtorFirmRepository = realtorFirmRepository;
            _mapper = mapper;
        }

        // GET: api/RealtorFirm
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RealtorFirmReadDto>>> GetRealtorFirms()
        {
            try
            {
                var realtorFirms = await realtorFirmRepository.GetAllAsync();
                return Ok(realtorFirms);
            }
            catch
            {
                return StatusCode(500, "An error occurred while retrieving realtor firms.");
            }
        }

        // GET: api/RealtorFirm/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RealtorFirmReadDto>> GetRealtorFirm(int id)
        {
            try
            {
                var realtorFirm = await realtorFirmRepository.GetByIdAsync(id);

                if (realtorFirm == null)
                {
                    return NotFound();
                }

                var realtorFirmReadDto = _mapper.Map<RealtorFirm>(realtorFirm);

                return Ok(realtorFirmReadDto);
            }
            catch
            {
                return StatusCode(500, "An error occurred while retrieving the realtor firm.");
            }
        }

        // PUT: api/RealtorFirm/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRealtorFirm(int id, RealtorFirmCreateDto realtorFirmCreateDto)
        {
            try
            {
                var realtorFirm = await realtorFirmRepository.GetByIdAsync(id);
                if (realtorFirm == null)
                {
                    return BadRequest();
                }

                _mapper.Map(realtorFirmCreateDto, realtorFirm);

                await realtorFirmRepository.Update(realtorFirm);

                return NoContent();
            }
            catch
            {
                return StatusCode(500, "An error occurred while updating the realtor firm.");
            }
        }

        // POST: api/RealtorFirm
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RealtorFirmReadDto>> PostRealtorFirm(RealtorFirmCreateDto realtorFirmCreateDto)
        {
            try
            {
                var realtorFirm = _mapper.Map<RealtorFirm>(realtorFirmCreateDto);

                if (realtorFirm == null)
                {
                    return BadRequest();
                }
                await realtorFirmRepository.Add(realtorFirm);

                var realtorFirmReadDto = _mapper.Map<RealtorFirmReadDto>(realtorFirm);

                return CreatedAtAction("GetRealtorFirm", new { id = realtorFirm.Id }, realtorFirmReadDto);
            }
            catch
            {
                return StatusCode(500, "An error occurred while creating the realtor firm.");
            }
        }

        // DELETE: api/RealtorFirm/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRealtorFirm(int id)
        {
            try
            {
                var realtorFirm = await realtorFirmRepository.GetByIdAsync(id);
                if (realtorFirm == null)
                {
                    return NotFound();
                }
                await realtorFirmRepository.Delete(realtorFirm);

                return NoContent();
            }
            catch
            {
                return StatusCode(500, "An error occurred while deleting the realtor firm.");
            }
        }
    }
}
