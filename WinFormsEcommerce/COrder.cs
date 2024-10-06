using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsEcommerce
{
    public class COrder
    {
        public int OrderId { get; set; }
        public int TotalPrice { get; set; }
        public string OrderStatus { get; set; }

        public int PaymentId { get; set; }
        public int UserId { get; set; }
    }
}
