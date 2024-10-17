using WebStore.Sales.Domain.Dtos.Request;
using WebStore.Sales.Domain.Dtos.Response;

namespace WebStore.Sales.Domain.Interfaces.Application.Service
{
    public interface ISaleService
    {
        Task<IEnumerable<SaleResponseDto>> GetAllSalesAsync();
        Task<SaleResponseDto> GetSaleByCodeAsync(string code);
        Task AddSaleAsync(SaleRequestDto sale);
        Task UpdateSaleAsync(SaleRequestDto sale);
        Task DeleteSaleAsync(string code);
    }
}
