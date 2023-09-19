using FluentValidation;
using Observer.Application.Features.StockFeatures.Queries.GetStockCount;
using Observer.Application.Features.WarehouseFeatures.Commands.CreateWarehouse;
using Observer.Application.Features.WarehouseFeatures.Queries.GetAllWarehouses;
using Observer.Application.Utilities.Mappings;
using Observer.Infrastructure.UnitOfWork;
using Observer.Infrastructure.UnitOfWork.Contracts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<IValidator<CreateWarehouseCommand>, CreateWarehouseCommandValidator>();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining(typeof(CreateWarehouseCommandHandler)));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining(typeof(GetAllWarehousesQueryHandler)));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining(typeof(GetStockCountQueryHandler)));

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
