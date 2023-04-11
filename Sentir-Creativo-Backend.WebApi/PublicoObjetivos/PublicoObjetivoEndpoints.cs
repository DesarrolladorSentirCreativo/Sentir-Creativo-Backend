using Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Controllers.PublicoObjetivos;

namespace Sentir_Creativo_Backend.WebApi.PublicoObjetivos;

public static class PublicoObjetivoEndpoints
{
    public static WebApplication UsePublicoObjetivoEndpoints(this WebApplication app)
    {
        app.MapGet("publico-objetivos/select", async (ISelectPublicoObjetivoController controller) => Results.Ok(await controller.Handle()));

        return app;
    }
}