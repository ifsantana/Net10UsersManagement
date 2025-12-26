using Microsoft.EntityFrameworkCore;
using System;
using UsersManagement.Api.Repositories;
using UsersManagement.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<PgDataContext>(options =>
    options.UseNpgsql(connectionString)
);
builder.Services.AddOpenApi();
builder.Services.AddValidation();
builder.Services.AddTransient<IUsersService, UsersService>();
builder.Services.AddTransient<IUserRepository, UserRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
