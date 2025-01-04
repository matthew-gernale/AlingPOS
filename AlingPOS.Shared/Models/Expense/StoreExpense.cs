
namespace AlingPOS.Shared.Models.Expense
{
    public class StoreExpense
    {
        public int Id { get; set; }
        public DateTime ExpenseDate { get; set; }
        public ExpenseCategory ExpenseCategory { get; set; }
        public string Description { get; set; } = string.Empty;
        public string PaidCompany { get; set; } = string.Empty;

        [Column(TypeName = "decimal(10,2)")]
        public decimal Amount { get; set; }
        public string ReceiptNo { get; set; } = string.Empty;
        public string ReceiptImg { get; set; } = string.Empty;
        public Guid CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public ApprovalStatus ApprovalStatus { get; set; }
        public DateTime ApprovalDate { get; set; }

    }
}
