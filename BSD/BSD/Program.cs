using BSD.BLL;
using BSD.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.Entity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Context>(c => c.UseSqlServer("Data Source=srv2\\pupils;Initial Catalog=BSDSR;Integrated Security=True;Trust Server Certificate=True;"));
builder.Services.AddScoped<ICustomerDal, CustomerDal>();
builder.Services.AddScoped<ICardDal, CardDal>();
builder.Services.AddScoped<IPurchaseDal, PurchaseDal>();
builder.Services.AddScoped<IGiftDal, GiftDal>();
builder.Services.AddScoped<ICategoryDal, CategoryDal>();
builder.Services.AddScoped<IDonationDal, DonationDal>();
builder.Services.AddScoped<ICustomerServies, CustomerServies>();
builder.Services.AddScoped<ICardServies, CardServies>();
builder.Services.AddScoped<IPurchasServies, PurchasServies>();
builder.Services.AddScoped<IGiftServies, GiftServies>();
builder.Services.AddScoped<ICategoryServies, CategoryServies>();
builder.Services.AddScoped<IDontionServies, DontionServies>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddCors();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3000"));
app.MapControllers();

app.Run();


