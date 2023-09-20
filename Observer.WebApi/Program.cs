using Microsoft.OpenApi.Models;
using Observer.Application.Features.StockFeatures.Queries.GetTotalStockCount;
using Observer.Application.Features.WarehouseFeatures.Commands.CreateWarehouse;
using Observer.Application.Features.WarehouseFeatures.Queries.GetAllWarehouses;
using Observer.Application.Publishers;
using Observer.Application.Publishers.Contracts;
using Observer.Application.Publishers.Subscribers;
using Observer.Application.Utilities.Mappings;
using Observer.Infrastructure.UnitOfWork;
using Observer.Infrastructure.UnitOfWork.Contracts;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<IStockLevelService, StockLevelService>();
builder.Services.AddTransient<IStockCheckoutSubscriber, StockCheckoutSubscriber>();
builder.Services.AddTransient<IStockArrivalSubscriber, StockArrivalSubscriber>();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining(typeof(CreateWarehouseCommandHandler)));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining(typeof(GetAllWarehousesQueryHandler)));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining(typeof(GetTotalStockCountQueryHandler)));

builder.Services.AddSwaggerGen(x =>
{
    x.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "OBSERVER API",
        Version = "1.0.0",
        Description = "API DOCUMENTATION",
        Contact = new OpenApiContact
        {
            Name = "Francisco Torreglosa",
            Email = "francisco.torreglosa@outlook.com",
            Url = new Uri("https://github.com/fjtorreglosaa")
        }
    });

    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

    x.IncludeXmlComments(xmlPath);
});

builder.Services.AddAutoMapper(typeof(MappingProfiles));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
