using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AnNhanhOnline;  // Namespace của ApplicationDbContext (sửa nếu khác)
using AnNhanhOnline.Models;  // Nếu có ApplicationUser
using Microsoft.AspNetCore.Identity.UI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Đăng ký DbContext với SQL Server LocalDB
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)
    ));

// Đăng ký Identity với ApplicationUser (nếu mày dùng custom user)
builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
{
    // Cấu hình Identity (có thể tùy chỉnh)
    options.SignIn.RequireConfirmedAccount = false; // Không bắt buộc confirm email khi dev
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
})
    .AddRoles<IdentityRole>()  // Hỗ trợ role (Admin, Customer...)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

// Thêm Authentication + Authorization
builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

// Nếu mày muốn dùng cookie authentication thay vì Identity default
// builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
//     .AddCookie(options => { options.LoginPath = "/Identity/Account/Login"; });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Hiện lỗi chi tiết khi dev
    app.UseMigrationsEndPoint();     // Hỗ trợ migration UI nếu cần
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();   // Quan trọng! Phải có trước UseAuthorization
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();  // Cần cho Identity pages (Login, Register, Forgot Password...)
// Seed role và admin user (chạy 1 lần)
using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

    string[] roles = { "Admin", "Customer" };
    foreach (var role in roles)
    {
        if (!await roleManager.RoleExistsAsync(role))
        {
            await roleManager.CreateAsync(new IdentityRole(role));
        }
    }

    var adminEmail = "admin@annhanh.com";
    var adminUser = await userManager.FindByEmailAsync(adminEmail);
    if (adminUser == null)
    {
        var user = new ApplicationUser
        {
            UserName = adminEmail,
            Email = adminEmail,
            EmailConfirmed = true,
            FullName = "Admin System"  // Nếu mày có field FullName
        };
        var result = await userManager.CreateAsync(user, "Admin@123");
        if (result.Succeeded)
        {
            await userManager.AddToRoleAsync(user, "Admin");
            Console.WriteLine("Admin user created successfully!");
        }
    }
}
app.Run();