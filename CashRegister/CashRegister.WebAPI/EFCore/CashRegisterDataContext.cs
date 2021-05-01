using CashRegister.Shared.DataModel;
using Microsoft.EntityFrameworkCore;

namespace CashRegister.WebAPI.EFCore
{
    public class CashRegisterDataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ReceiptLine> ReceiptLines { get; set; }

        public DbSet<Receipt> Receipts { get; set; }

        public CashRegisterDataContext(DbContextOptions<CashRegisterDataContext> options)
        : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.ProductName).IsRequired();
            modelBuilder.Entity<Product>().Property(p => p.UnitPrice).IsRequired().HasColumnType("numeric(6,2)");

            modelBuilder.Entity<ReceiptLine>().Property(rl => rl.Amount).IsRequired();
            modelBuilder.Entity<ReceiptLine>().Property(rl => rl.TotalPrice).IsRequired().HasColumnType("numeric(6,2)");

            modelBuilder.Entity<Receipt>().Property(r => r.ReceiptTimestamp).IsRequired();
            modelBuilder.Entity<Receipt>().Property(r => r.TotalPrice).IsRequired().HasColumnType("numeric(6,2)");
        }
    }
}
