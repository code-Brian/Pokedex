using Microsoft.EntityFrameworkCore;
using Pokedex.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession();
// We're going to need Cors since React is going to be our "cross-origin" app
builder.Services.AddCors();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<DBContext>(options => {
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();

// After we've added CORS to the builder, we need to tell the app to use it and "AllowOrigins".
app.UseCors("AllowOrigins");
app.UseRouting();

app.UseAuthorization();

// the name is whatever we want our controller route to be. In this instance it's set to "client".
// we could potentiall make one called "admin", for instance.
// the pattern filters what routes we want to catch. '/admin' would catch all the admin routes, if we wanted.
// the defaults will go to the controller called "Main".
// the "action" is a route called index that serves up the "index".
app.MapControllerRoute(
    name: "client",
    pattern: "{*url}",
    defaults: new {controller = "Main", action="Index"}
    );

app.Run();