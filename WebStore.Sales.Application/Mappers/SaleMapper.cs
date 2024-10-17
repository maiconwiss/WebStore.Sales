using WebStore.Sales.Domain.Dtos.Request;
using WebStore.Sales.Domain.Entities;
using WebStore.Sales.Domain.Interfaces.Application.Mappers;

namespace WebStore.Sales.Application.Mappers
{
    public class SaleMapper : ISaleMapper
    {
        public Sale MapToEntity(SaleRequestDto saleRequestDto)
        {
            var sale = new Sale();
            {
                sale.SaleCode = saleRequestDto.Code;
            }

            return sale;
        }
    }
}
