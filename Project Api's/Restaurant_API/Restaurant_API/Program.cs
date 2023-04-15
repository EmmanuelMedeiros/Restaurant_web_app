using Microsoft.EntityFrameworkCore;
using Restaurant_API.Business;
using Restaurant_API.Business.Implementation;
using Restaurant_API.Context;
using Restaurant_API.Repository;
using Restaurant_API.Repository.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCors();
var connection = builder.Configuration["MySQLConnection:MySQLConnectionString"];
builder.Services.AddDbContext<MySQLContext>(options => options.UseMySql(
    connection,
    new MySqlServerVersion(new Version(8, 0, 29)))
);
builder.Services.AddScoped<IMenuRepositoryInterface, MenuRepositoryImplementation>();
builder.Services.AddScoped<IMenuBusinessInterface, MenuBusinessImplementation>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(c => {
    c.AllowAnyHeader();
    c.AllowAnyMethod();
    c.AllowAnyOrigin();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
