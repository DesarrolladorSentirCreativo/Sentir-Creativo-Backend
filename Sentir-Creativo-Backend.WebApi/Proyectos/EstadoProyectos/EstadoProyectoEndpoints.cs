using Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Controllers.EstadoProyectos;

namespace Sentir_Creativo_Backend.WebApi.Proyectos.EstadoProyectos;

public static class EstadoProyectoEndpoints
{
    public static WebApplication UseEstadoProyectoEndpoints(this WebApplication app)
    {
        app.MapGet("estado-proyectos/select", async (ISelectEstadoProyectoController controller) => Results.Ok(await controller.Handle()));

        return app;
    }
}