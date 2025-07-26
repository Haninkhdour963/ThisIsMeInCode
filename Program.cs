using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// تسجيل خدمات MVC (Controllers with Views)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// تهيئة الـ HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// ضبط التوجيه الافتراضي للكنترولر والاكشن
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Haneen}/{action=Index}/{id?}");

app.Run();
