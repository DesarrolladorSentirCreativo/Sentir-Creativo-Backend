using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO;

namespace Sentir_Creativo_Backend.WebApi.Audiencias.Audiencias;

public static class AudienciaEndpoints
{
    public static WebApplication UseAudienciaEndpoints(this WebApplication app)
    {
        app.MapGet("/audiencias/{id}", async (HttpContext context, int id, IGetByIdAudienciaController controller) =>
        {
            // Obtener el ID de la URL
            var idSegment = context.Request.RouteValues["id"].ToString();
            int itemId = int.Parse(idSegment);

            return Results.Ok(await controller.Handle(itemId));
        });

        app.MapGet("/audiencias", async (string? Search, string? Sort, int PageIndex, int PageSize, IPaginationAudienciaController controller) => 
            Results.Ok(await controller.Handle(
                new AudienciaPaginationDto
                {
                    Search = Search,
                    Sort = Sort,
                    PageIndex = PageIndex,
                    PageSize = PageSize
                }))
        );


        return app;
    }
}