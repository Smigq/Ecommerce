using Ecommerce.Data;
using Ecommerce.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public PaymentController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Payment>>> GetAllPayments()
        {
            var payments = await _dataContext.Payment.ToListAsync();

            return Ok(payments);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Payment>> GetPaymentWithId(int id)
        {
            var payment = await _dataContext.Payment.FindAsync(id);
            if (payment is null)
                return NotFound("Payment not found");

            return Ok(payment);
        }

        [HttpPost]
        public async Task<ActionResult<List<Payment>>> AddPayment([FromBody] Payment payment)
        {
            _dataContext.Payment.Add(payment);
            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Payment.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Payment>>> UpdatePayment([FromBody] Payment payment)
        {
            var dbpayment = await _dataContext.Payment.FindAsync(payment.PaymentId);
            if (dbpayment is null)
                return NotFound("Payment not found");

            dbpayment.PaymentMethod = payment.PaymentMethod;
            dbpayment.PaymentStatus = payment.PaymentStatus;
            dbpayment.OrderId = payment.OrderId;

            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Payment.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Payment>>> DeletePayment(int id)
        {
            var dbpayment = await _dataContext.Payment.FindAsync(id);
            if (dbpayment is null)
                return NotFound("Payment not found");

            _dataContext.Payment.Remove(dbpayment);

            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Payment.ToListAsync());
        }
    }
}
