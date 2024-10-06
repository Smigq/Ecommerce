using Ecommerce.Data;
using Ecommerce.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public ProductController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts() 
        {
            var products = await _dataContext.Product.ToListAsync();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductWithId(int id)
        {
            var product = await _dataContext.Product.FindAsync(id);
            if (product is null)
                return NotFound("Product not found");

            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<List<Product>>> AddProduct([FromBody]Product product)
        {
            _dataContext.Product.Add(product);
            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Product.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Product>>> UpdateProduct([FromBody] Product product)
        {
            var dbproduct = await _dataContext.Product.FindAsync(product.ProductId);
            if (dbproduct is null)
                return NotFound("Product not found");

            dbproduct.Name = product.Name;
            dbproduct.Description = product.Description;
            dbproduct.Price = product.Price;
            dbproduct.StockQuantity = product.StockQuantity;
            dbproduct.OrderDetailsId = product.OrderDetailsId;

            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Product.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Product>>> DeleteProduct(int id)
        {
            var dbproduct = await _dataContext.Product.FindAsync(id);
            if (dbproduct is null)
                return NotFound("Product not found");

            _dataContext.Product.Remove(dbproduct);

            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Product.ToListAsync());
        }
    }
}
