using Ecommerce.Data;
using Ecommerce.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public OrderDetailsController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<OrderDetails>>> GetAllOrderDetails()
        {
            var orders = await _dataContext.OrderDetails.ToListAsync();

            return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDetails>> GetOrderDetailsWithId(int id)
        {
            var order = await _dataContext.OrderDetails.FindAsync(id);
            if (order is null)
                return NotFound("Order details not found");

            return Ok(order);
        }

        [HttpPost]
        public async Task<ActionResult<List<OrderDetails>>> AddOrderDetails([FromBody] OrderDetails order)
        {
            _dataContext.OrderDetails.Add(order);
            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.OrderDetails.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<OrderDetails>>> UpdateOrderDetails([FromBody] OrderDetails order)
        {
            var dborder = await _dataContext.OrderDetails.FindAsync(order.OrderDetailsId);
            if (dborder is null)
                return NotFound("Order details not found");

            dborder.Result = order.Result;
            dborder.OrderId = order.OrderId;
            dborder.ProductId = order.ProductId;

            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.OrderDetails.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<OrderDetails>>> DeleteOrderDetails(int id)
        {
            var dborder = await _dataContext.OrderDetails.FindAsync(id);
            if (dborder is null)
                return NotFound("OrderDetails not found");

            _dataContext.OrderDetails.Remove(dborder);

            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.OrderDetails.ToListAsync());
        }
    }
}
