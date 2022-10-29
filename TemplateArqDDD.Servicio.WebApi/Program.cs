using TemplateArqDDD.Servicio.WebApi.Modulos.Inyeccion;
using TemplateArqDDD.Servicio.WebApi.Modulos.Mapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMapper();//no viene en la plantilla WEBAPI
builder.Services.AddInjection(builder.Configuration);//no viene en la plantilla WEBAPI

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.MapControllers(); //no viene en la plantilla WEBAPI

app.Run();
