using WebStore.Sales.Domain.Dtos.Request;
using WebStore.Sales.Domain.Entities;

namespace WebStore.Sales.Domain.Interfaces.Application.Mappers
{
    public interface ISaleMapper
    {
        Sale MapToEntity(SaleRequestDto saleRequestDto);
    }
}
