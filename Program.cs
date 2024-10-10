using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using ProductsAPI.Data;
using ProductsAPI.Repositories;
using ProductsAPI.Services;

var builder = WebApplication.CreateBuilder(args);
Env.Load();

//Create the environment variables

var dbHost = Environment.GetEnvironmentVariable("DB_HOST");
var dbPort = Environment.GetEnvironmentVariable("DB_PORT");
var dbName = Environment.GetEnvironmentVariable("DB_NAME");
var dbUsername = Environment.GetEnvironmentVariable("DB_USERNAME");
var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");

//Configuration of the connection string

var connectionString = $"server={dbHost};port={dbPort};database={dbName};uid={dbUsername};password={dbPassword}";

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.Parse("8.0.80-mysql")));


builder.Services.AddScoped<ICategoryRepository, CategoryServices>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseWelcomePage(new WelcomePageOptions
{
    Path = "/"
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
