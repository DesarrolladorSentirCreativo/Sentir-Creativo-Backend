namespace Sentir_Creativo_Backend.SharedKernel.Application.Features.Queries;

public class PaginationBaseQuery
{
    public string? Search { get; set; }
    public string? Sort { get; set; }
    public int PageIndex { get; set; }
    public int PageSize { get; set; }
}