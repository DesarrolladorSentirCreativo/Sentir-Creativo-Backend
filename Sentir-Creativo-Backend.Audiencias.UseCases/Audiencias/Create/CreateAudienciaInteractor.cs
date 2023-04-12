using FluentValidation;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.Create;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.GetById;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO.Audiencias;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;

namespace Sentir_Creativo_Backend.Audiencias.UseCases.Audiencias.Create;

public class CreateAudienciaInteractor : ICreateAudienciaInputPort
{
    private readonly IWriteRepository<Entities.POCOEntities.Audiencia,int> _audienciaWriteRepository;
    private readonly ICreateAudienciaOutputPort _outputPort;
    private readonly IEnumerable<IValidator<CreateAudienciaDto>> _validators;
    
    public CreateAudienciaInteractor(
        IWriteRepository<Entities.POCOEntities.Audiencia,int> audienciaWriteRepository,
        ICreateAudienciaOutputPort outputPort,
        IEnumerable<IValidator<CreateAudienciaDto>> validators)
    {
         _audienciaWriteRepository = audienciaWriteRepository;
         _outputPort = outputPort;
         _validators = validators;
    }
    
    public async ValueTask Handle(CreateAudienciaDto dto)
    {
        //validamos los datos
        await Validator<CreateAudienciaDto>.Validate(dto, _validators);
    }
}