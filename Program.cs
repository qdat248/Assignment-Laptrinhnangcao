using Microsoft.EntityFrameworkCore;
using WebBanDoAn.Data;

var builder = WebApplication.CreateBuilder(args);

// 1. Cấu hình Database Connection thông qua Dependency Injection
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. Thêm các dịch vụ cho MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// 3. Cấu hình Pipeline xử lý yêu cầu HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();