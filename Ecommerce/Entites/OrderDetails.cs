using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Entites
{
    public class OrderDetails
    {
        public int OrderDetailsId { get; set; }
        public required string Result { get; set; }

        public int? OrderId { get; set; }

        public int ProductId { get; set; }
    }
}
