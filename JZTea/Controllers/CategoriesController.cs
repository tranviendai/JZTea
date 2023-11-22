using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JZTea.Data;
using JZTea.Models;

namespace JZTea.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly JZTeaContext _context;

        public CategoriesController(JZTeaContext context)
        {
            _context = context;
        }

        // GET: api/Categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategory()
        {
          if (_context.Category == null)
          {
              return NotFound();
          }
            var category = await _context.Category.Select(e => new
            {
                id = e.id,
                name = e.name,
                icon = e.icon,
                products = e.products.Select(e => new
                {
                    id = e.id,
                    name = e.name,
                    price = e.price,
                    discount = e.discount,
                    postDate = e.postDate,
                    image = e.image,
                    description = e.description,
                    isPublish = e.isPublish
                })
            }).ToListAsync();
            return Ok(category);
        }
       
    }
}
