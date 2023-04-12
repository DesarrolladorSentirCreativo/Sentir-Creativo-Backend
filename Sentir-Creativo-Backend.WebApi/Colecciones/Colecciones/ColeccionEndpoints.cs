using Sentir_Creativo_Backend.Colecciones.BusinessObject.Contracts.Controllers.Colecciones;

namespace Sentir_Creativo_Backend.WebApi.Colecciones.Colecciones;

public static class ColeccionEndpoints
{
    public static WebApplication UseColeccionEndpoints(this WebApplication app)
    {
        app.MapGet("colecciones/select", async (ISelectColeccionController controller) => Results.Ok(await controller.Handle()));

        return app;
    }
}