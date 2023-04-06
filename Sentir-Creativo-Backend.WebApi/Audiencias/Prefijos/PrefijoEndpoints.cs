using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Prefijos;

namespace Sentir_Creativo_Backend.WebApi.Audiencias.Prefijos;

public static class PrefijoEndpoints
{
    public static WebApplication UsePrefijoEndpoints(this WebApplication app)
    {
        app.MapGet("prefijos/select", async (ISelectPrefijoController controller) => Results.Ok(await controller.Handle()));

        return app;
    }
}