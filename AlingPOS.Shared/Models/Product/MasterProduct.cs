
namespace AlingPOS.Shared.Models.Product
{
    public class MasterProduct
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ProductImg { get; set; } = string.Empty;
        public string SKU { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public int ProductCategoryId { get; set; }
        public MasterInventory MasterInventory { get; set; }
        [JsonIgnore]
        public List<OrderItem>? OrderItem { get; set; }
    }
}
