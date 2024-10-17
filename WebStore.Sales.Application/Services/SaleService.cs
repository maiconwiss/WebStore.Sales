using WebStore.Sales.Domain.Dtos.Request;
using WebStore.Sales.Domain.Dtos.Response;
using WebStore.Sales.Domain.Entities;
using WebStore.Sales.Domain.Interfaces.Application.Mappers;
using WebStore.Sales.Domain.Interfaces.Application.Service;
using WebStore.Sales.Domain.Interfaces.Infra.Data.Repository;

namespace WebStore.Sales.Application.Services
{
    public class SaleService : ISaleService
    {

        private readonly IBaseRepository<Sale> _repository;
        private readonly ISaleMapper _mapper;

        public SaleService(IBaseRepository<Sale> repository, ISaleMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public Task AddSaleAsync(SaleRequestDto saleRequestDto)
        {
            var sale = _mapper.MapToEntity(saleRequestDto);
            _repository.Insert(sale);
            return Task.CompletedTask;
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
