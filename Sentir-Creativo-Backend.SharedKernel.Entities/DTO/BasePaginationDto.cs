namespace Sentir_Creativo_Backend.SharedKernel.Entities.DTO;

public abstract class BasePaginationDto
{
    public string? Search { get; set; }
    public string? Sort { get; set; }
    public int PageIndex { get; set; }
    public int PageSize { get; set; }
}