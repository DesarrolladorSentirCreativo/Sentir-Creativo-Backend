using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Sentir_Creativo_Backend.SharedKernel.Entities.Exceptions;

namespace Sentir_Creativo_Backend.WebExceptionsPresenters
{
    public class NotFoundExceptionHandler : BaseExceptionHandler, IExceptionHandler
    {
        public ValueTask Handle(ExceptionContext context)
        {
            var exception = context.Exception as NotFoundException;
            return SetResult(context, StatusCodes.Status404NotFound, exception!.Message, exception.Detail);
        }
    }
}
