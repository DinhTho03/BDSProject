global using dotnet_rpg.Models;
global using Microsoft.EntityFrameworkCore;
global using dotnet_rpg.Data;
using Microsoft.OpenApi.Models;
using dotnet_rpg.IService;
using dotnet_rpg.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddScoped<IProperty, PropertyRepository>();
builder.Services.AddScoped<IFullContract, FullContractRepository>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(options =>
{
    options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
});
app.UseHttpsRedirection();

app.MapControllers();

app.Run();
