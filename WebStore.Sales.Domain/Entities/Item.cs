namespace WebStore.Sales.Domain.Entities
{
    public class Item : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountAmount { get; set; }
        public bool IsCancelled { get; set; }
    }
}
