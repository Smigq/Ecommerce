using Ecommerce.Entites;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data
{
    public class DataContext : DbContext
    {
        public DataContext() { }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure User entity
            modelBuilder.Entity<Users>().ToTable("Users");
            modelBuilder.Entity<Users>()
                .HasKey(u => u.UserId);

            modelBuilder.Entity<Users>()
                .Property(u => u.UserName)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Users>()
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<Users>()
                .Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(255);

            // Configure Payment entity
            modelBuilder.Entity<Payment>().ToTable("Payment");
            modelBuilder.Entity<Payment>()
                .HasKey(p => p.PaymentId);

            modelBuilder.Entity<Payment>()
                .Property(p => p.PaymentMethod)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Payment>()
                .Property(p => p.PaymentStatus)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValue("processing");

            modelBuilder.Entity<Payment>()
                .Property(p => p.OrderId)
                .IsRequired();


            // Configure Product entity
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Product>()
                .HasKey(p => p.ProductId);

            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .Property(p => p.Description)
                .HasMaxLength(500);

            modelBuilder.Entity<Product>()
                .Property(p => p.StockQuantity)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .Property (p => p.OrderDetailsId)
                .IsRequired();

            // Configure Order entity
            modelBuilder.Entity<Orders>().ToTable("Orders");
            modelBuilder.Entity<Orders>()
                .HasKey(o => o.OrderId);

            modelBuilder.Entity<Orders>()
                .Property(o => o.OrderStatus)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Orders>()
                .Property(o => o.UserId)
                .IsRequired(); // Optional field, no foreign key constraint

            modelBuilder.Entity<Orders>()
                .Property(o => o.PaymentId)
                .IsRequired(); // Optional field, no foreign key constraint

            modelBuilder.Entity<Orders>()
               .Property(o => o.TotalPrice)
               .IsRequired();

            // Configure OrderDetails entity
            modelBuilder.Entity<OrderDetails>().ToTable("OrderDetails");
            modelBuilder.Entity<OrderDetails>()
                .HasKey(od => od.OrderDetailsId);

            modelBuilder.Entity<OrderDetails>()
                .Property(od => od.Result)
                .IsRequired()
                .HasMaxLength(500);

            modelBuilder.Entity<OrderDetails>()
                .Property(o => o.OrderId)
                .IsRequired();

            modelBuilder.Entity<OrderDetails>()
               .Property(od => od.ProductId)
               .IsRequired(); // Optional field, no foreign key constraint
        }
    }
}
