using Company_CaseStudy.Data;
using Company_CaseStudy.Interface;
using Company_CaseStudy.Rebosatry;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(option =>
option.UseSqlServer(builder.Configuration.GetConnectionString("Con")));
builder.Services.AddScoped<IEmpolyee , EmpolyeeRepo>();
builder.Services.AddScoped<IDepartment , DepartmentRepo>();
builder.Services.AddScoped<IContract , ContractRepo>();
builder.Services.AddScoped<IProduct , ProjecetRepo>();
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
