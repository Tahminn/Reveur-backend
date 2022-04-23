using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer;
using RepositoryLayer.Data;
using ServiceLayer;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddFluentValidation();
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddRepositoryLayer();
builder.Services.AddServiceLayer();

#region Connection String  
builder.Services.AddDbContext<AppDbContext>(options => options
                    .UseSqlServer(builder.Configuration
                                        .GetConnectionString("DefaultConnection")));
#endregion

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
