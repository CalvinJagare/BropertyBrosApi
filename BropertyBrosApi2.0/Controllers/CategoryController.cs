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

namespace BropertyBrosApi2._0.Controllers
{
    //Author: Alla
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CategoryController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Category
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        // GET: api/Category/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryReadDto>> GetCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            
            if (category == null)
            {
                return NotFound();
            }
            
            var categoryReadDto = _mapper.Map<CategoryReadDto>(category);

            return Ok(categoryReadDto);
        }

        // PUT: api/Category/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(int id, CategoryCreateDto categoryCreateDto)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return BadRequest();
            }
           
            _mapper.Map(categoryCreateDto, category); 

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/Category
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CategoryReadDto>> PostCategory(CategoryCreateDto categoryCreateDto)
        {
            var category = _mapper.Map<Category>(categoryCreateDto);

            _context.Categories.Add(category);
            await _context.SaveChangesAsync();

            var categoryReadDto = _mapper.Map<CategoryReadDto>(category);

            return CreatedAtAction("GetCategory", new { id = category.Id }, categoryReadDto);
        }

        // DELETE: api/Category/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }
    }
}
