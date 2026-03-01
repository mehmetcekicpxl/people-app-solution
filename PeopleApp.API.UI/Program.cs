using Microsoft.EntityFrameworkCore;
using PeopleApp.Application.Interfaces;
using PeopleApp.Application.Services;
using PeopleApp.Infrastructure.Data;
using PeopleApp.Infrastructure.Data.DefaultData;
using PeopleApp.Infrastructure.Interfaces;
using PeopleApp.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("PeopleConnection");
if (connectionString != null)
{
    builder.Services.AddDbContext<PeopleAppDbContext>(options =>
    {
        options.UseSqlServer(connectionString);
    });
    builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
    builder.Services.AddScoped<IDepartment, DepartmentService>();
}

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

var provider = app.Services;

using (var scope = app.Services.CreateScope())
{   
    try
    {
        SeedData.SeedDatabase(scope);
    }
    catch (Exception)
    {        
       
    }
}

app.Run();
