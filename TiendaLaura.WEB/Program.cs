using TiendaLaura.DAL.DAL;
using Microsoft.EntityFrameworkCore;
using TiendaLaura.Business.Abstract;
using TiendaLaura.Business.Business;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//var conexion = Configuration["ConnectionStrings:conexion_SqlServer"];
var configuration = builder.Configuration;
var conexion = configuration.GetValue<string>("ConnectionStrings:conexion_SqlServer");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(conexion));
builder.Services.AddScoped<IPrendaBusiness, PrendaBusiness>();
builder.Services.AddScoped<ITipoPrendaBusiness, TipoPrendaBusiness>();
builder.Services.AddScoped<IColorBusiness, ColorBusiness>();


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Prendas}/{action=Index}/{id?}");

app.Run();
