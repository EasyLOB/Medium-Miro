
// API-DOTNET.csproj
// <ImplicitUsings>enable</ImplicitUsings> -> disable
// <Nullable>enable</Nullable> -> disable

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers(); // my-api
builder.Services.AddControllersWithViews(); // my-mvc

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// my-mvc
// ASP.NET Core API - CORS
builder.Services.AddCors(o =>
{
    //o.AddPolicy("AllowOrigin", p => p.AllowAnyOrigin());
    o.AddPolicy("AllowOrigin", p => p
        .AllowAnyHeader()
        .AllowAnyMethod()
        // The CORS protocol does not allow specifying a wildcard (any) origin and credentials at the same time.
        // Configure the CORS policy by listing individual origins if credentials needs to be supported.
        //.AllowAnyOrigin()
        .AllowCredentials()
        .SetIsOriginAllowed(_ => true)
    );
});
builder.Services.AddHttpContextAccessor();

var app = builder.Build();

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection(); // my-mvc http://localhost:3000 without https
app.UseStaticFiles(); // my-mvc \wwwroot

app.UseAuthorization();

    // my-mvc
    //app.MapControllerRoute(
    //    name: "default",
    //    pattern: "{controller=Home}/{action=Index}/{id?}");
    // Miro
    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Miro}/{action=Index}/{id?}");

app.MapControllers();

app.Run();
