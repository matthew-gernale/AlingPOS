
namespace AlingPOS.Shared.Models.Product
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;

        [JsonIgnore]
        public List<MasterProduct>? MasterProducts { get; set; }
    }
}
