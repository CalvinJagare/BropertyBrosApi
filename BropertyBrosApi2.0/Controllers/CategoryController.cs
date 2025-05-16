using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BropertyBrosApi.Data;
using BropertyBrosApi.Models;
using BropertyBrosApi2._0.DTOs.Category;
using AutoMapper;
using BropertyBrosApi2._0.Repositories.RepInterfaces;
using BropertyBrosApi2._0.Constants;
using Microsoft.AspNetCore.Authorization;

namespace BropertyBrosApi2._0.Controllers
{
    //Author: Alla
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryRepository categoryRepository, IMapper mapper)
        {

            this.categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        // GET: api/Category
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryReadDto>>> GetCategories()
        {
            try
            {
                var categories = await categoryRepository.GetAllAsync();
                var categoryReadDtos = _mapper.Map<IEnumerable<CategoryReadDto>>(categories);

                return Ok(categoryReadDtos);
            }
            catch
            {
                return StatusCode(500, "An error occurred while retrieving categories.");
            }
        }

        // GET: api/Category/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryReadDto>> GetCategory(int id)
        {
            try
            {
                var category = await categoryRepository.GetByIdAsync(id);

                if (category == null)
                {
                    return NotFound();
                }

                var categoryReadDto = _mapper.Map<CategoryReadDto>(category);

                return Ok(categoryReadDto);
            }
            catch
            {
                return StatusCode(500, "An error occurred while retrieving categories.");
            }
        }

        // PUT: api/Category/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = IdentityRoles.Admin)]
        public async Task<IActionResult> PutCategory(int id, CategoryCreateDto categoryCreateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var category = await categoryRepository.GetByIdAsync(id);
                if (category == null)
                {
                    return BadRequest();
                }

                _mapper.Map(categoryCreateDto, category);

                await categoryRepository.Update(category);

                return Ok(categoryCreateDto);
            }
            catch
            {
                return StatusCode(500, "An error occurred while retrieving categories.");
            }
        }

        // POST: api/Category
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = IdentityRoles.Admin)]
        public async Task<ActionResult<CategoryReadDto>> PostCategory(CategoryCreateDto categoryCreateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var category = _mapper.Map<Category>(categoryCreateDto);
                if (category == null)
                {
                    return BadRequest();
                }
                await categoryRepository.Add(category);

                var categoryReadDto = _mapper.Map<CategoryReadDto>(category);

                return CreatedAtAction("GetCategory", new { id = category.Id }, categoryReadDto);
            }
            catch
            {
                return StatusCode(500, "An error occurred while retrieving categories.");
            }
        }

        // DELETE: api/Category/5
        [HttpDelete("{id}")]
        [Authorize(Roles = IdentityRoles.Admin)]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            try
            {
                var category = await categoryRepository.GetByIdAsync(id);
                if (category == null)
                {
                    return NotFound();
                }

                await categoryRepository.Delete(category);

                return NoContent();
            }
            catch
            {
                return StatusCode(500, "An error occurred while retrieving categories.");
            }
        }
    }
}
