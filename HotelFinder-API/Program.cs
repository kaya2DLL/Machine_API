using HotelFinder.Business.Abstract;
using HotelFinder.Business.Concrete;
using HotelFinder_DataAccess.Concrete;
using Mac.Business.Abstract;
using Mac.Business.Concrete;

;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<IMacService,MacManager>();
builder.Services.AddSingleton<IMachineService,MachineManager>();
builder.Services.AddSingleton<IDatasService, DatasManager>();
builder.Services.AddSingleton<MacRepository, MacRepository>();
builder.Services.AddSingleton<MachineRepository, MachineRepository>();
builder.Services.AddSingleton<DatasRepository, DatasRepository>();

builder.Services.AddSwaggerDocument();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseOpenApi();
app.UseSwaggerUi3();
app.MapControllers();

app.Run();
