using Microsoft.EntityFrameworkCore;
using MyProject.Data; // Replace 'MyProject' with your actual project name if it's different!
using MyProject.Services;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MyProject.Data.ApiContext>(options =>
    options.UseInMemoryDatabase("CourseDb"));
// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<CourseService>();

var app = builder.Build();

app.UseAuthentication(); // Checks "Who are you?"
app.UseAuthorization();  // Checks "Are you allowed to be here?"

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();

