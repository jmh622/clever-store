global using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Serilog;
using WebAPI.Data.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CleverStoreContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("CleverStore")));

builder.Host.UseSerilog((context, lc) => 
    lc.WriteTo.Console()
      .ReadFrom.Configuration(builder.Configuration));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();