using Sentir_Creativo_Backend.Archivos.BusinessObject.Presenters.Archivos;
using Sentir_Creativo_Backend.Archivos.BusinessObject.ViewModels;

namespace Sentir_creativo_Backend.Archivos.Presenters.Archivos;

public class GetByIdArchivoPresenter : IGetByIdArchivoPresenter
{
    public GetByIdArchivoViewModel GetByIdArchivoViewModel { get; private set; }
    
    public ValueTask Handle(GetByIdArchivoViewModel modelView)
    {
        GetByIdArchivoViewModel = modelView;

        return ValueTask.CompletedTask;
    }
    
}