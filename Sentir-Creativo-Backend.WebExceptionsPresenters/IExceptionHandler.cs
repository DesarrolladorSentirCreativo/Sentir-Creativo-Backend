using Microsoft.AspNetCore.Mvc.Filters;

namespace Sentir_Creativo_Backend.WebExceptionsPresenters;

public interface IExceptionHandler
{
    ValueTask Handle(ExceptionContext context);
}