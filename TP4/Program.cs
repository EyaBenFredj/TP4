using Hotellerie_X.Models.HotellerieModel;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ✅ Add services for MVC (controllers + views)
builder.Services.AddControllersWithViews();

// ✅ Register DbContext
builder.Services.AddDbContext<HotellerieDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HotellerieConnection")));

var app = builder.Build();

// ✅ Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// ✅ Set default route to HotelsController → Index
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Hotels}/{action=Index}/{id?}");

// ❌ Removed Razor Pages mapping — not needed
// app.MapRazorPages();

app.Run();