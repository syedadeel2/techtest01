using System.Collections.Generic;
using TechTest01.Domain.Catalog;

namespace TechTest01.Services.Catalog
{
    public interface IProductService
    {
        ICollection<Product> GetProducts();
        Product GetById(int id);
    }
}
