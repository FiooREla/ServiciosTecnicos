using ServiciosTecnicos.Services.WebApi.Extensions.Inyection;
using ServiciosTecnicos.Services.WebApi.Extensions.Mapper;
using ServiciosTecnicos.Services.WebApi.Extensions.Authentication;
using ServiciosTecnicos.Services.WebApi.Extensions.Feature;
using ServiciosTecnicos.Services.WebApi.Modules.Validator;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMapper();
builder.Services.AddFeature(builder.Configuration);
builder.Services.AddInyection(builder.Configuration);
builder.Services.AddAuthentication(builder.Configuration);
builder.Services.AddValidator();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("policityApiServicios");
app.UseAuthentication();
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

    
app.Run();
