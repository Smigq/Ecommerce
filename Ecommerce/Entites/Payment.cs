namespace Ecommerce.Entites
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public required string PaymentMethod { get; set; } = string.Empty;

        public required string PaymentStatus { get; set; } = "processing";

        public required int OrderId { get; set; }

    }
}
