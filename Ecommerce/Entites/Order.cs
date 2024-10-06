using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Entites
{
    public class Orders
    {
        public int OrderId { get; set; }
        public string OrderStatus { get; set; }
        public int UserId { get; set; }
        public int TotalPrice { get; set; }

        public int PaymentId { get; set; }

    }
}
