using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsEcommerce
{
    public class COrderDetails
    {
        public int OrderDetailsId { get; set; }
        public string Result { get; set; }
        public int? OrderId { get; set; }
        public int ProductId { get; set; }
    }
}
