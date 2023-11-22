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
    public class ProductsController : ControllerBase
    {
        private readonly JZTeaContext _context;

        public ProductsController(JZTeaContext context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProduct()
        {
            var products = await _context.Product.Select(e => new
            {
                id = e.id,
                name = e.name,
                price = e.price,
                discount = e.discount,
                image = e.image,
                postDate = e.postDate,
                description = e.description,
                isPublish = e.isPublish,
                categoryID = e.categoryID
            }).ToListAsync();
            if (_context.Product == null)
          {
              return NotFound();
          }
            return Ok(products);
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
          if (_context.Product == null)
          {
              return NotFound();
          }
            var product = await _context.Product.Select(e => new
            {
                id = e.id,
                name = e.name,
                price = e.price,
                discount = e.discount,
                description = e.description,
                postDate = e.postDate,
                image = e.image,
                isPublish = e.isPublish,
                categoryID = e.categoryID
            }).FirstOrDefaultAsync(i => i.id == id);

            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.id)
            {
                return BadRequest();
            }
            var newProduct = new Product()
            {
                id = product.id,
                name = product.name,
                price = product.price,
                discount = product.discount,
                description = product.description,
                postDate = product.postDate,
                image = product.image,
                isPublish = product.isPublish,
                categoryID = product.categoryID
            };
           
            _context.Entry(newProduct).State = EntityState.Modified;
            _context.Entry(newProduct).Property(x => x.id).IsModified = false;
            _context.Entry(newProduct).Property(x => x.postDate).IsModified = false;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(newProduct);
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            var newProduct = new Product()
            {
                id = product.id,
                name = product.name,
                price = product.price,
                discount = product.discount,
                description = product.description,
                postDate = DateTime.Now,
                image = product.image,
                isPublish = false,
                categoryID = product.categoryID
            };

            await _context.Product.AddAsync(newProduct);
            await _context.SaveChangesAsync();

            return Ok(newProduct);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            if (_context.Product == null)
            {
                return NotFound();
            }
            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Product.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductExists(int id)
        {
            return (_context.Product?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
