namespace WebStore.Sales.Domain.Dtos
{
    public class SaleItemDto
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountAmount { get; set; }
        public bool IsCancelled { get; set; }
        public decimal TotalItemValue { get; set; }
    }
}
