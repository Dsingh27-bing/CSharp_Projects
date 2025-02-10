using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace Infrastructure;

public class ECommerceDbContext:DbContext
{
    public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options ):base(options)
    {
    }
    
    public DbSet<Order> Orders { get; set; }
    public DbSet<Order_Details> Order_Details { get; set; }
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>()
            .HasMany(o => o.Order_Details)
            .WithOne(od => od.Order)
            .HasForeignKey(od => od.Order_Id);
    }
    
    
    
}
