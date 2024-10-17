namespace WebStore.Sales.Domain.Entities
{
    public class Sale : BaseEntity
    {
        public string SaleCode { get; set; }
        public DateTime SaleDate { get; set; }
        public Branch Branch { get; set; }
        public List<Item> Items { get; set; }
        public Client Client { get; set; }
    }
}
