using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Audiencias;

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

        return app;
    }
}