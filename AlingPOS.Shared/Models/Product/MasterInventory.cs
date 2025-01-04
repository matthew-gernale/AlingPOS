
namespace AlingPOS.Shared.Models.Product
{
    public class MasterInventory
    {
        public int Id { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Qty { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal AtCost { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal CurrentPrice { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal PreviousPrice { get; set; }
        public MasterProduct MasterProduct { get; set; }
        public int MasterProductId { get; set; }
    }
}
