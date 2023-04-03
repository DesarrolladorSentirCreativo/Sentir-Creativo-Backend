using MediatR;
using Sentir_Creativo_Backend.Application.Mappers;
using Sentir_Creativo_Backend.Audiencias.Application.Audiencias.Features.Queries.Paginator;
using Sentir_Creativo_Backend.Audiencias.Persistence;
using Sentir_Creativo_Backend.SharedKernel.Application;
using Sentir_Creativo_Backend.SharedKernel.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddMappingServices(builder.Configuration);
builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddMediatR(typeof(PaginationAudienciaQueryHandler).Assembly);
builder.Services.AddAudienciasPersistenceServices(builder.Configuration);



builder.Services.AddControllers();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();