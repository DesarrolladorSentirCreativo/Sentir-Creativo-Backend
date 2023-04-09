using Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Controllers.TipoProyectos;

namespace Sentir_Creativo_Backend.WebApi.Proyectos.TipoProyectos;

public static class TipoProyectoEndpoints
{
    public static WebApplication UseTipoProyectoEndpoints(this WebApplication app)
    {
        app.MapGet("tipo-proyectos/select", async (ISelectTipoProyectoController controller) => Results.Ok(await controller.Handle()));

        return app;
    }
}