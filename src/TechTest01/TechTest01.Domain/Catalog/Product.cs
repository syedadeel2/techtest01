
namespace TechTest01.Domain.Catalog
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Slug { get; set; } // this is the (sanitized) seo name for the product (e.g. /t-shirt)
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
