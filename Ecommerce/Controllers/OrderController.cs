using Ecommerce.Data;
using Ecommerce.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public OrderController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Orders>>> GetAllOrders()
        {
            var orders = await _dataContext.Orders.ToListAsync();
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Orders>> GetOrderWithId(int id)
        {
            var order = await _dataContext.Orders.FindAsync(id);
            if (order is null)
                return NotFound("Order not found");

            return Ok(order);
        }

        [HttpPost]
        public async Task<ActionResult<List<Orders>>> AddOrder([FromBody] Orders order)
        {
            _dataContext.Orders.Add(order);
            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Orders.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Orders>>> UpdateOrder([FromBody] Orders order)
        {
            var dborder = await _dataContext.Orders.FindAsync(order.OrderId);
            if (dborder is null)
                return NotFound("Order not found");

            dborder.OrderId = order.OrderId;
            dborder.OrderStatus = order.OrderStatus;
            dborder.UserId = order.UserId;
            dborder.TotalPrice = order.TotalPrice;
            dborder.PaymentId = order.PaymentId;

            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Orders.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Orders>>> DeleteOrder(int id)
        {
            var dborder = await _dataContext.Orders.FindAsync(id);
            if (dborder is null)
                return NotFound("Payment not found");

            _dataContext.Orders.Remove(dborder);

            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Orders.ToListAsync());
        }
    }
}
