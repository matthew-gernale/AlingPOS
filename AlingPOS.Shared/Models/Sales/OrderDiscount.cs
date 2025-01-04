
namespace AlingPOS.Shared.Models.Sales
{
    public class OrderDiscount
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DiscountType DiscountType { get; set; }
        public int DiscUsage { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Amount { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Percentage { get; set; }

        public bool IsActive { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public DateTime DateCreated { get; set; }

        [JsonIgnore]
        public List<User>? User { get; set; }
        public List<SalesOrder>? SalesOrders { get; set; }
    }
}
