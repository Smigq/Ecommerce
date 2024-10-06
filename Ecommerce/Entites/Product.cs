namespace Ecommerce.Entites
{
        public class Product
        {
            public int ProductId { get; set; }
            public required string Name { get; set; } = string.Empty;
            public required int Price { get; set; }
            public string Description { get; set; } = string.Empty;
            public int StockQuantity { get; set; }

            public int OrderDetailsId { get; set; }
    }
}
