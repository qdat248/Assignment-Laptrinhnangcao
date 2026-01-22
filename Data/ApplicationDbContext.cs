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
            base.OnModelCreating(modelBuilder);

            // CATEGORY
    
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Thức ăn nhanh", Description = "Burger, Gà rán, Pizza" },
                new Category { CategoryID = 2, CategoryName = "Đồ uống", Description = "Nước ngọt, trà, cafe" },
                new Category { CategoryID = 3, CategoryName = "Combo", Description = "Combo tiết kiệm" },
                new Category { CategoryID = 4, CategoryName = "Gà rán", Description = "Các món gà chiên giòn" },
                new Category { CategoryID = 5, CategoryName = "Pizza", Description = "Pizza các loại" },
                new Category { CategoryID = 6, CategoryName = "Tráng miệng", Description = "Bánh ngọt, kem" }


            );

            // PRODUCT
       
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductID = 1, ProductName = "Burger Bò", Price = 55000, CategoryID = 1, Image = "burger_bo.jpg", Description = "Burger bò truyền thống" },
                new Product { ProductID = 2, ProductName = "Burger Gà", Price = 50000, CategoryID = 1, Image = "burger_ga.jpg", Description = "Burger gà giòn" },
                new Product { ProductID = 3, ProductName = "Gà rán", Price = 45000, CategoryID = 1, Image = "ga_ran.jpg", Description = "Gà rán giòn rụm" },
                new Product { ProductID = 4, ProductName = "Coca Cola", Price = 15000, CategoryID = 2, Image = "coca.jpg", Description = "Nước ngọt có ga" },
                new Product { ProductID = 5, ProductName = "Pepsi", Price = 15000, CategoryID = 2, Image = "pepsi.jpg", Description = "Pepsi mát lạnh" },
                new Product { ProductID = 6, ProductName = "Gà rán cay", Price = 48000, CategoryID = 4, Image = "ga_cay.jpg", Description = "Gà cay Hàn Quốc" },
                new Product { ProductID = 7, ProductName = "Gà rán truyền thống", Price = 45000, CategoryID = 4, Image = "ga_truyen_thong.jpg", Description = "Gà rán giòn" },
                new Product { ProductID = 8, ProductName = "Pizza Hải Sản", Price = 120000, CategoryID = 5, Image = "pizza_hai_san.jpg", Description = "Pizza hải sản phô mai" },
                new Product { ProductID = 9, ProductName = "Pizza Bò", Price = 110000, CategoryID = 5, Image = "pizza_bo.jpg", Description = "Pizza bò nướng" },
                new Product { ProductID = 10, ProductName = "Kem Vani", Price = 20000, CategoryID = 6, Image = "kem_vani.jpg", Description = "Kem mát lạnh" }
            );

       
            // USER
 
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserID = 1,
                    FullName = "Admin System",
                    Email = "admin@fastfood.com",
                    Pass = "123456",
                    Address = "FPT Polytechnic",
                    NumberPhone = "0900000000",
                    Role = "Admin",
                    GoogleID = null
                },
                new User
                {
                    UserID = 2,
                    FullName = "Nguyễn Văn A",
                    Email = "customer1@gmail.com",
                    Pass = "123456",
                    Address = "Hà Nội",
                    NumberPhone = "0911111111",
                    Role = "Customer",
                    GoogleID = null
                },
                new User
                {
                    UserID = 3,
                    FullName = "Trần Thị B",
                    Email = "customer2@gmail.com",
                    Pass = "123456",
                    Address = "TP.HCM",
                    NumberPhone = "0922222222",
                    Role = "Customer",
                    GoogleID = "google_123456"
                },
          new User
          {
              UserID = 4,
              FullName = "Lê Văn C",
              Email = "customer3@gmail.com",
              Pass = "123456",
              Address = "Đà Nẵng",
              NumberPhone = "0933333333",
              Role = "Customer",
              GoogleID = null
          },
    new User
    {
        UserID = 5,
        FullName = "Phạm Thị D",
        Email = "customer4@gmail.com",
        Pass = "123456",
        Address = "Cần Thơ",
        NumberPhone = "0944444444",
        Role = "Customer",
        GoogleID = "google_78910"
    }
);


            // COMBO

            modelBuilder.Entity<Combo>().HasData(
                new Combo
                {
                    ComboID = 1,
                    ComboName = "Combo Tiết Kiệm",
                    Price = 80000,
                    Description = "1 Burger + 1 Coca"
                },
                new Combo
                {
                    ComboID = 2,
                    ComboName = "Combo Gia Đình",
                    Price = 180000,
                    Description = "2 Burger + 2 Gà rán  + 2 Nước"
                },
                 new Combo
                 {
                     ComboID = 3,
                     ComboName = "Combo Cặp Đôi",
                     Price = 190000,
                     Description = "2 Burger + 2 Nước"
                 },
                  new Combo
                  {
                      ComboID = 4,
                      ComboName = "Combo Bố Con",
                      Price = 200000,
                      Description = "2 Burger + 2 Gà rán + 2 Pizza  + 2 Nước"
                  },
                   new Combo
                   {
                       ComboID = 5,
                       ComboName = "Combo Đặc Biệt",
                       Price = 220000,
                       Description = "2 Burger + 2 Gà rán + 2 Pizza + 2 Tráng Miệng + 2 Nước"
                   },
                     new Combo
                     {
                         ComboID = 6,
                         ComboName = "Combo Gà Rán",
                         Price = 170000,
                         Description = "2 Gà rán + 1 Coca"
                     },
                       new Combo
                       {
                           ComboID = 7,
                           ComboName = "Combo Pizza",
                           Price = 150000,
                           Description = "1 Pizza + 2 Nước"
                       },
                         new Combo
                         {
                             ComboID = 8,
                             ComboName = "Combo Sinh Viên",
                             Price = 160000,
                             Description = "Burger + Nước + Khoai"
                         }
            );

     
            // ORDER
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    OrderID = 1,
                    OrderDate = DateTime.Now,
                    TotalAmount = 95000,
                    Status = "Đã giao",
                    UserId = 2
                },
                new Order
                {
                    OrderID = 2,
                    OrderDate = DateTime.Now,
                    TotalAmount = 180000,
                    Status = "Đang giao",
                    UserId = 3
                },
            new Order
            {
                OrderID = 3,
                OrderDate = DateTime.Now,
                TotalAmount = 95000,
                Status = "Chưa giao",
                UserId = 4
            },
    new Order
    {
        OrderID = 4,
        OrderDate = DateTime.Now,
        TotalAmount = 150000,
        Status = "Đã giao",
        UserId = 5
    }
);

            //OrderDetail

            modelBuilder.Entity<OrderDetail>().HasData(
                new OrderDetail
                {
                    OrderDetailID = 1,
                    OrderID = 1,
                    ProductID = 1,
                    ComboID = null,
                    Quantity = 1,
                    UnitPrice = 55000
                },
                new OrderDetail
                {
                    OrderDetailID = 2,
                    OrderID = 1,
                    ProductID = 4,
                    ComboID = null,
                    Quantity = 1,
                    UnitPrice = 15000
                },
                new OrderDetail
                {
                    OrderDetailID = 3,
                    OrderID = 2,
                    ProductID = null,
                    ComboID = 2,
                    Quantity = 1,
                    UnitPrice = 180000
                },
             
          new OrderDetail
          {
              OrderDetailID = 4,
              OrderID = 3,
              ProductID = 6,
              ComboID = null,
              Quantity = 2,
              UnitPrice = 48000
          },
    new OrderDetail
    {
        OrderDetailID = 5,
        OrderID = 4,
        ProductID = null,
        ComboID = 4,
        Quantity = 1,
        UnitPrice = 150000
    }
);
        }
    }
}
    