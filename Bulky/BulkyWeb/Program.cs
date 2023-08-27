using BulkyWeb.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
/*
 Añadimos el DbContext en base a la clase que va a tener la configuración, ademas debemos especificar que va a usar Sql Server

Una vez hecho eso debemos pasar la cadena de conexión configurada en el appsettings
 */
builder.Services.AddDbContext<ApplicationDbContext>(options=> 
        options.UseSqlServer(builder.Configuration.GetConnectionString("DataBaseConnection")));



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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
