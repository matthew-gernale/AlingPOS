
namespace AlingPOS.Shared.Models.Sales
{
    public class OrderItem
    {
        public int Id { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal OrderQty { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal SubTotal { get; set; }
        public SalesOrder SalesOrder { get; set; }
        public Guid SalesOrderId { get; set; }
        public MasterProduct MasterProduct { get; set; }
        public int MasterProductId { get; set; }
    }
}
