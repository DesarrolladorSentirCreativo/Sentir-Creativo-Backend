using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Sentir_Creativo_Backend.WebExceptionsPresenters;

public class ApiExceptionFilterAttribute : ExceptionFilterAttribute
{
    private readonly IDictionary<Type,IExceptionHandler> _exceptionHandlers;
    
    public ApiExceptionFilterAttribute(IDictionary<Type,IExceptionHandler> exceptionHandlers)
    {
        _exceptionHandlers = exceptionHandlers;
    }

    public override void OnException(ExceptionContext context)
    {
        Type exceptionType = context.Exception.GetType();

        if (_exceptionHandlers.ContainsKey(exceptionType))
        {
            _exceptionHandlers[exceptionType].Handle(context);
        }
        else
        {
            new BaseExceptionHandler().SetResult(context, StatusCodes.Status500InternalServerError,
                "Ha ocurrido un error al procesar la peticion", "");
        }
        base.OnException(context);
    }
}