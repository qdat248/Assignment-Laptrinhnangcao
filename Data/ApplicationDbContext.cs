using Microsoft.EntityFrameworkCore;
using WebBanDoAn.Models;

namespace WebBanDoAn.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Combo> Combos { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Data cho Category
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Thức ăn nhanh", Description = "Burger, Gà rán..." },
                new Category { CategoryID = 2, CategoryName = "Đồ uống", Description = "Nước ngọt, cafe..." }
            );

            // Seed Data cho Product
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductID = 1, ProductName = "Burger Bò", Price = 55000, CategoryID = 1, Image = "burger.jpg", Description = "Ngon tuyệt" },
                new Product { ProductID = 2, ProductName = "Coca Cola", Price = 15000, CategoryID = 2, Image = "coca.jpg", Description = "Lạnh" }
            );
        }
    }
}