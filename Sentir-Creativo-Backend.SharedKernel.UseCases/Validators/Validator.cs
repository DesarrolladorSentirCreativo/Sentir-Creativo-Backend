using FluentValidation;
using FluentValidation.Results;

namespace Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;

public static class Validator<TModel>
{
    public static Task<List<ValidationFailure>> Validate(TModel model, IEnumerable<IValidator<TModel>> validators, bool causesException = true)
    {
        var failures = validators
                    .Select( v => v.Validate(model))
                    .SelectMany( r => r.Errors)
                    .Where(f => f != null)
                   .ToList();

        if (failures.Any() && causesException)
        {
            throw new ValidationException(failures);
        }

        return Task.FromResult(failures);

    }
}