using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Ecommerce.Entites
{
    public class Users
    {
        public int UserId { get; set; }

        public required string UserName { get; set; } = string.Empty;

        public required string Email { get; set; } = string.Empty;

        public required string Password { get; set; } = string.Empty;
    }
}
