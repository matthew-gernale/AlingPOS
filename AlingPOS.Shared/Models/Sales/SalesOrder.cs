
namespace AlingPOS.Shared.Models.Sales
{
    public class SalesOrder
    {
        public Guid Id { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal PaymentAmount { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal PaymentChange { get; set; }
        public PaymentType PaymentType { get; set; }
        public string RefNo { get; set; } = string.Empty;
        [Column(TypeName = "decimal(10,2)")]
        public decimal Discount { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal SubTotal { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Total { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [JsonIgnore]
        public List<OrderItem> OrderItems { get; set; }

        public OrderDiscount? OrderDiscount { get; set; }
        public int OrderDiscountId { get; set; }
    }
}
