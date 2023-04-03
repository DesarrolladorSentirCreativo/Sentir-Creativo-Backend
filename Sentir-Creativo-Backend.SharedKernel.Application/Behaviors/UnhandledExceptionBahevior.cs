using MediatR;
using Microsoft.Extensions.Logging;

namespace Sentir_Creativo_Backend.SharedKernel.Application.Behaviors;

public class UnhandledExceptionBahevior<TRequest,TResponse> : IPipelineBehavior<TRequest,TResponse> where TRequest : IRequest<TResponse>
{
    private readonly ILogger<TRequest> _logger;
    
    public UnhandledExceptionBahevior(ILogger<TRequest> logger)
    {
        _logger = logger;
    }
    
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        try
        {
            return await next();
        }
        catch (Exception ex)
        {
            var requestName = typeof(TRequest).Name;
            _logger.LogError(ex, " Application Request: Sucedio una exception request {Name} {@Request}", requestName, request);
            throw new Exception(" Application Request con errores");
        }
    }
}