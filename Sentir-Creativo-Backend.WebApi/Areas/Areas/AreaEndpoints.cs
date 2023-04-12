using Sentir_Creativo_Backend.Areas.BusinessObject.Contracts.Controllers.Areas;

namespace Sentir_Creativo_Backend.WebApi.Areas.Areas;

public static class AreaEndpoints
{
    public static WebApplication UseAreaEndpoints(this WebApplication app)
    {
        app.MapGet("areas/select", async (ISelectAreaController controller) => Results.Ok(await controller.Handle()));

        return app;
    }
}