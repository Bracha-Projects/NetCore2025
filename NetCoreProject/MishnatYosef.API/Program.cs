using Microsoft.EntityFrameworkCore;
using MishnatYosef.Core.Repositories;
using MishnatYosef.Core.Services;
using MishnatYosef.Data;
using MishnatYosef.Data.Repositories;
using MishnatYosef.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//Add dependencies to the repositories
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IProductOnSellRepository, ProductOnSellRepository>();
builder.Services.AddScoped<IOrderedProductRepository, OrderedProductRepository>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IStationRepository, DistributionStationRepository>();
builder.Services.AddScoped<ISellRepository, SellRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
//Add dependencies to the Services
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IProductOnSellService, ProductOnSellService>();
builder.Services.AddScoped<IOrderedProductService, OrderedProductService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IDistributionStationService, DistributionStationService>();
builder.Services.AddScoped<ISellService, SellService>();
builder.Services.AddScoped<IProductService, ProductService>();
//Add dependencies to DataContext
builder.Services.AddDbContext<DataContext>(
    options => options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=my_db"));

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

app.UseAuthorization();

app.MapControllers();

app.Run();
