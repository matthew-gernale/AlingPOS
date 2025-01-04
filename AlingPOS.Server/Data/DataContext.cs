
namespace AlingPOS.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
        public DbSet<EmpAttendance> EmpAttendances { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; } 

        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
        public DbSet<StoreExpense> StoreExpenses { get; set; }

        public DbSet<MasterInventory> MasterInventories { get; set; }
        public DbSet<MasterProduct> MasterProducts { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<OrderDiscount> OrderDiscounts { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<SalesOrder> SalesOrders { get; set; }
    }
}
