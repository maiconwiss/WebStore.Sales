using WebStore.Sales.Domain.Dtos.Request;
using WebStore.Sales.Domain.Dtos.Response;
using WebStore.Sales.Domain.Interfaces.Application.Service;

namespace WebStore.Sales.Application.Services
{
    public class SaleService : ISaleService
    {
        public Task AddSaleAsync(SaleRequestDto sale)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSaleAsync(string code)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SaleResponseDto>> GetAllSalesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SaleResponseDto> GetSaleByCodeAsync(string code)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSaleAsync(SaleRequestDto sale)
        {
            throw new NotImplementedException();
        }
    }
}
