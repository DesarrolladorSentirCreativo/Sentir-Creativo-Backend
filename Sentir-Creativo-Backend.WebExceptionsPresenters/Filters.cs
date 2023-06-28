using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.SharedKernel.Entities.Exceptions;

namespace Sentir_Creativo_Backend.WebExceptionsPresenters;

public static class Filters
{
    public static void Register(MvcOptions options)
    {
        options.Filters.Add(new ApiExceptionFilterAttribute(
            new Dictionary<Type, IExceptionHandler>
        {
            { typeof(GeneralException), new GeneralExceptionHandler() },
            { typeof(ValidationException), new ValidationExceptionHandler() },
            { typeof(NotFoundException), new NotFoundExceptionHandler() }
        }
    ));
}
}