using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsEcommerce
{
    public class CProducts
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int StockQuantity { get; set; }

        public int OrderDetailsId { get; set; }

    }
}
