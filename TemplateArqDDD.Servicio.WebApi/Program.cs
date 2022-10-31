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

builder.WebHost.ConfigureKestrel(options => //no viene en la plantilla WEBAPI
{
    options.ListenAnyIP(4990); // to listen for incoming http connection on port 5001
                               // options.ListenAnyIP(7001, configure => configure.UseHttps()); // to listen for incoming https connection on port 7001
});

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseSwaggerUI();

app.UseRouting();

app.UseSwagger();

app.UseAuthorization();

app.MapControllers();

app.Run();
