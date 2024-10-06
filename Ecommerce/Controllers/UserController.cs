using Ecommerce.Data;
using Ecommerce.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public UserController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Users>>> GetAllUsers()
        {
            var users = await _dataContext.Users.ToListAsync();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Users>> GetUserWithId(int id)
        {
            var user = await _dataContext.Users.FindAsync(id);
            if (user is null)
                return NotFound("User not found");

            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<List<Users>>> AddUser([FromBody] Users user)
        {
            _dataContext.Users.Add(user);
            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Users.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Users>>> UpdateUser([FromBody] Users user)
        {
            var dbuser = await _dataContext.Users.FindAsync(user.UserId);
            if (dbuser is null)
                return NotFound("User not found");

            dbuser.UserName = user.UserName;
            dbuser.Email = user.Email;
            dbuser.Password = user.Password;

            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Users.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Users>>> DeleteUser(int id)
        {
            var dbuser = await _dataContext.Users.FindAsync(id);
            if (dbuser is null)
                return NotFound("Product not found");

            _dataContext.Users.Remove(dbuser);

            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Users.ToListAsync());
        }
    }
}
