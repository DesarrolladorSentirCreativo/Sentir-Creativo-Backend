using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.Formatos;

namespace Sentir_Creativo_Backend.WebApi.Servicios.Formatos;

public static class FormatoEndpoints
{
    public static WebApplication UseFormatoEndpoints(this WebApplication app)
    {
        app.MapGet("formatos/select", async (ISelectFormatoController controller) => Results.Ok(await controller.Handle()));

        return app;
    }
}