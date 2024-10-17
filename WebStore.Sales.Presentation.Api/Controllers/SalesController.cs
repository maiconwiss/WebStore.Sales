using Microsoft.AspNetCore.Mvc;
using WebStore.Sales.Domain.Dtos.Request;
using WebStore.Sales.Domain.Interfaces.Application.Service;

namespace WebStore.Sales.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly ISaleService _saleService;

        public SalesController(ISaleService saleService)
        {
            _saleService = saleService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSales()
        {
            var sales = await _saleService.GetAllSalesAsync();
            return Ok(sales);
        }

        [HttpGet("{code}")]
        public async Task<IActionResult> GetSale(string code)
        {
            var sale = await _saleService.GetSaleByCodeAsync(code);
            if (sale == null) return NotFound();
            return Ok(sale);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSale([FromBody] SaleRequestDto sale)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _saleService.AddSaleAsync(sale);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSale([FromBody] SaleRequestDto sale)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _saleService.UpdateSaleAsync(sale);
            return Ok();
        }

        [HttpDelete("{code}")]
        public async Task<IActionResult> DeleteSale(string code)
        {
            await _saleService.DeleteSaleAsync(code);
            return Ok();
        }
    }
}
