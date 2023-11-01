using CalculadoraCDB.Application.Interfaces;
using CalculadoraCDB.Application.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<ICalcularCdbService,CalcularCdbService>();
builder.Services.AddScoped<ICalcularImpostorendaService, CalcularImpostorendaService>();
builder.Services.AddScoped<ICalcularInvestimentoService, CalcularInvestimentoService>();


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
