using Assessment_ValeriaPiedrahita.data;
using DotNetEnv;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//config db
Env.Load();

var db_host = Environment.GetEnvironmentVariable("DB_HOST");
var db_port = Environment.GetEnvironmentVariable("DB_PORT");
var db_database = Environment.GetEnvironmentVariable("DB_DATABASE");
var db_username = Environment.GetEnvironmentVariable("DB_USERNAME");
var db_password = Environment.GetEnvironmentVariable("DB_PASSWORD");

var conectionDb = $"server={db_host};port={db_port};database={db_database};uid={db_username};password={db_password}";

builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(conectionDb, ServerVersion.Parse("8.0.20-mysql")));

// Add services to the container.

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
