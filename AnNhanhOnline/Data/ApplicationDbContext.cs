using AnNhanhOnline.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Combo> Combos { get; set; }
    public DbSet<ComboDetail> ComboDetails { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Fluent API ví dụ
        builder.Entity<ComboDetail>()
            .HasKey(cd => new { cd.ComboId, cd.ProductId });

        builder.Entity<ComboDetail>()
            .HasOne(cd => cd.Combo)
            .WithMany(c => c.ComboDetails)
            .HasForeignKey(cd => cd.ComboId);

        builder.Entity<ComboDetail>()
            .HasOne(cd => cd.Product)
            .WithMany(p => p.ComboDetails)
            .HasForeignKey(cd => cd.ProductId);
    }
}