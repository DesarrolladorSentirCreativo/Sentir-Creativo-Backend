using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Sentir_Creativo_Backend.SharedKernel.Entities.Exceptions;

namespace Sentir_Creativo_Backend.WebExceptionsPresenters;

public class GeneralExceptionHandler : BaseExceptionHandler, IExceptionHandler
{
    public ValueTask Handle(ExceptionContext context)
    {
        var exception = context.Exception as GeneralException;
        return SetResult(context, StatusCodes.Status500InternalServerError,exception!.Message,exception.Detail);
    }
}