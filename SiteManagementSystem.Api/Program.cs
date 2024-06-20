using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using SiteManagementSystem.Api.Filters;
using SiteManagementSystem.Repository;
using SiteManagementSystem.Service;
using SiteManagementSystem.Service.Apartments.Configurations;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"),
        x => { x.MigrationsAssembly(typeof(RepositoryAssembly).Assembly.GetName().Name); });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(ServiceAssembly).Assembly);

builder.Services.AddControllers(x => x.Filters.Add<ValidationFilter>());

builder.Services.AddFluentValidationAutoValidation();

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

builder.Services.AddApartmentService();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

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
