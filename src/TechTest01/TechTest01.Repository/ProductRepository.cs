using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest01.Domain.Catalog;
using TechTest01.Repository.Contexts;

namespace TechTest01.Repository
{
    public class ProductRepository : IRepository<Product>
    {

        private ProductsContext productsContext;

        #region Ctro
        public ProductRepository()
        {
            this.productsContext = new ProductsContext();
        }

        #endregion

        #region methods

        public ICollection<Product> GetEntities()
        {
            var products = this.productsContext.Products.ToList();
            return products;
        }

        public Product GetEntityById(int id)
        {
            var product = this.productsContext.Products.FirstOrDefault(x => x.Id == id);
            return product;
        }

        #endregion
    }
}
